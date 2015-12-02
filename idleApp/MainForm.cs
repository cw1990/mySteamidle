using idleApp.Class;
using idleApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Security.Principal;
using System.Timers;
using System.Windows.Forms;
using Update;

namespace idleApp
{
    enum Status
    {
        Start = 0,
        Exit = 1,
        End = 2
    }
    public partial class  MainForm : Form
    {
        UpdateForm upform;
        List<AppMember> applist;
        //RunApp runapp;
        CmdHelper chelp;
        BackgroundWorker _bw;
        Config config = new Config();
        //Client wbc;
        System.Timers.Timer appTimer;
        SingleRun sr;

        #region 临时变量
        string tmpcmd = "";
        int AppIndex = 0;
        #endregion

        #region 默认参数
        string updateUrl = "http://zha7.net/update.xml";//升级配置的XML文件地址
        int cardTime = 20;//分钟
        List<string> defBlackList = new List<string> { "303700", "368020", "335590", "267420" };
        #endregion

        public MainForm()
        {
            InitializeComponent();

            //初始化参数
            initializeConfig();
            //启动自动更新
            checkUpdate();
            //初始化Form
            initializeForm(config);

#if !DEBUG
            MessageBox.Show("你的徽章页面有可能是大余1页的，请选择有卡挂的页面复制源码", "游戏很多的大佬请注意");
#endif
        }

        #region 更新Form
        /// <summary>
        /// 获取挂机消息
        /// </summary>
        /// <param name="time"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        private void LoadAppMsg(int status, string id)
        {
            string time = DateTime.Now.ToLongTimeString();
            string running = "";
            switch (status)
            {
                case (int)Status.Start:
                    this.Invoke(new Action(delegate
                    {
                        LoadAppImage(id);
                        timelabel.Text = time;
                        for (int i = 0; i < applist.Count; i++)
                        {
                            if (applist[i].Id == id)
                            {
                                game_label.Text = applist[i].Name;
                                running = applist[i].Name;
                            }
                        }
                    }));
                    CMDprint("开始运行" + running);
                    return;
                    break;
                case (int)Status.End:
                    this.Invoke(new Action(delegate
                    {
                        timelabel.Text = "Null";
                        game_label.Text = "";
                    }));
                    CMDprint(running + "结束运行");
                    break;
                case (int)Status.Exit:
                    this.Invoke(new Action(delegate
                    {
                        timelabel.Text = "Null";
                        game_label.Text = "";
                        LoadAppImage("End");
                        applistView.Items.Clear();
                    }));
                    startToolStripMenuItem.Text = "开始";
                    CMDprint("挂机结束");
                    applist.Clear();
                    break;
            }
        }

        /// <summary>
        /// 获取图
        /// </summary>
        /// <param name="appid">ID</param>
        public void LoadAppImage(string appid)
        {
            if (appid != "End")
            {
                try
                {
                    picApp.LoadAsync("http://cdn.akamai.steamstatic.com/steam/apps/" + appid + "/capsule_184x69.jpg");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error From:" + e.TargetSite + " Message" + e.Message);
                }
            }
            else
            {
                picApp.Image = null;
                Graphics g = picApp.CreateGraphics();
                g.Clear(Color.White);
            }

        }

        #endregion

        #region 事件
        string ClipboardText;
        private void getIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClipboardText = getClipboard();
            _bw.RunWorkerAsync("Start to Get");
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppIndex = 0;
            startOrStopApp();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kill();
            config.CardTime = Settings.Default.CardTime;
            string content = JsonHelper.SerializeObject(config);
            FileHelper.WriteFile("config.json", content);
        }

        private void clearTextbutton_Click(object sender, EventArgs e)
        {
            scrtextBox.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://zha7.net");
        }

        private void dELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (applistView.SelectedItems.Count > 0)
            {
                applist.RemoveAt(applistView.SelectedItems[0].Index);
                applistView.Items.Remove(applistView.SelectedItems[0]);
            }
        }

        private void timeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8是退格
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(timeTextBox.Text))
                Settings.Default.CardTime = int.Parse(timeTextBox.Text);
        }

        private void blackTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8是退格
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void blackAddButton_Click(object sender, EventArgs e)
        {
            if (blackTextBox.Text != "输入黑名单ID")
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = blackTextBox.Text;
                backlistView.Items.Add(lvi);
                config.Blacklist.Add(blackTextBox.Text);
            }
        }

        private void blackDelButton_Click(object sender, EventArgs e)
        {
            if (backlistView.SelectedItems.Count > 0)
            {
                if (!defBlackList.Contains(backlistView.SelectedItems[0].Text))
                {
                    config.Blacklist.RemoveAt(backlistView.SelectedItems[0].Index);
                    backlistView.Items.Remove(backlistView.SelectedItems[0]);
                }
            }
        }

        private void CmdrichTextBox_TextChanged(object sender, EventArgs e)
        {
            CmdrichTextBox.SelectionStart = CmdrichTextBox.Text.Length; //Set the current caret position at the end
            CmdrichTextBox.ScrollToCaret(); //Now scroll it automatically
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Text == "控制台")
            {
                CmdtextBox.Focus();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                Hide();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void twohourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAllTwoHour();
            CMDprint("一键2小时");
        }

        private void clearAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kill();
            CMDprint("清理进程");
        }
        #endregion

        #region 其他方法

        public int getRandomNum()
        {
            int minValue, maxValue;
            minValue = 100000;
            maxValue = 900000;
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int tmp = 0;
            tmp = ra.Next(minValue, maxValue); //随机取数
            return tmp;
        }

        private string getClipboard()
        {
            // GetDataObject检索当前剪贴板上的数据     
            IDataObject iData = Clipboard.GetDataObject();
            // 将数据与指定的格式进行匹配，返回bool   
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // GetData检索数据并指定一个格式    
                return (string)iData.GetData(DataFormats.Text);
            }
            else
            {
                //MessageBox.Show("请复制徽章页面的源代码!", "错误");
                return null;
            }
        }

        /// <summary>
        /// 初始化参数
        /// </summary>
        private void initializeConfig()
        {
            Settings.Default.AppEnabled = false;
            string stream = FileHelper.ReadFile("config.json");
            if (!string.IsNullOrEmpty(stream) && stream != "Error")
            {
                config = JsonHelper.DeserializeJsonToObject<Config>(stream);
                Settings.Default.CardTime = config.CardTime;
                CMDprint("开始装载数据");
            }
            else
            {
                CMDprintError("配置文件读取失败,启用默认配置");
                config = new Config();
                config.CardTime = cardTime;
                config.Blacklist = defBlackList;
                config.UpdateUrl = updateUrl;
            }
        }

        /// <summary>
        /// 初始化Form
        /// </summary>
        private void initializeForm(Config config)
        {
#if DEBUG
            this.Text = "[Debug]卡牌小工具4.1.3 情怀版 By zha7";
#else
            this.Text = "卡牌小工具4.1.3 情怀版 By zha7";
#endif
            notifyIcon1.Text = "迷之卡牌程序";
            notifyIcon1.Icon = this.Icon;

            //数据装载
            HelpString help = new HelpString();
            helpRichTextBox.Text = help.ToString();

            blackTextBox.Text = "输入黑名单ID";
            timeTextBox.Text = config.CardTime.ToString();
            foreach (string value in config.Blacklist)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = value;
                backlistView.Items.Add(lvi);
            }
            CMDprint("数据装载完毕");

            chelp = new CmdHelper();

            applist = new List<AppMember>();

            //int Snum = getRandomNum();
            //Snumlabel.Text = "SNum:" + Snum.ToString();
            //wbc = new Client(Snum);

            _bw = new BackgroundWorker();
            _bw.DoWork += bw_DoWork;
            _bw.RunWorkerCompleted += bw_RunWorkerCompleted;
        }

        private void startOrStopApp()
        {
            if (applist.Count != 0)
            {
                foreach(AppMember item in applist)
                {
                    if(Convert.ToDouble(item.Time) < 2.00)
                    {
                        MessageBox.Show("部分游戏时间不足2小时，可能不会出卡", "注意");
                        break;
                    }
                }
                Kill();
                //Start
                if (Settings.Default.AppEnabled == false)
                {
                    startToolStripMenuItem.Text = "停止";
                    Start();
                }
                else
                {
                    appTimer.Stop();
                    appTimer.Close();
                    Kill();
                    startToolStripMenuItem.Text = "开始";
                    CMDprint("用户手动停止挂机");
                    try
                    {
                        LoadAppMsg((int)Status.Exit, applist[AppIndex].Id);
                    }
                    catch { }
                }
            }           
        }

        private void Start()
        {
            try
            {
                sr = new SingleRun(applist[AppIndex]);
                sr.StartApp();
                LoadAppMsg((int)Status.Start, applist[AppIndex].Id);
                appTimer = new System.Timers.Timer();
#if DEBUG
                appTimer.Interval = 5000;
                appTimer.Start();
#endif
#if !DEBUG
                appTimer.Interval = Settings.Default.CardTime;
#endif
                appTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            }
            catch(Exception e)
            {
                Settings.Default.AppEnabled = false;
                LoadAppMsg((int)Status.Exit, applist[AppIndex].Id);
                CMDprintError(e.Message);
                MessageBox.Show(e.Message);
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (--sr.Virtualcard < 1)
            {
                sr.StopApp();
                LoadAppMsg((int)Status.End, applist[AppIndex].Id);
                ++AppIndex;
                try
                {
                    sr = new SingleRun(applist[AppIndex]);
                    sr.StartApp();
                    LoadAppMsg((int)Status.Start, applist[AppIndex].Id);
                }
                catch
                {
                    Settings.Default.AppEnabled = false;
                    Kill();
                    appTimer.Stop();
                    appTimer.Close();
                    LoadAppMsg((int)Status.Exit, applist[AppIndex - 1].Id);
                }
            }
        }

        private void StartAllTwoHour()
        {
            if (applist.Count != 0)
            {
                MessageBox.Show("一键2小时的时候别挂机，挂机别2小时", "注意");
                foreach (AppMember item in applist)
                {
                    if (Convert.ToDouble(item.Time) < 2.00)
                    {
                        SingleRun srtwo = new SingleRun(item);
                        srtwo.StartTwoApp();
                    }
                }
            }
        }
        /// <summary>
        /// 清理
        /// </summary>
        /// <returns></returns>
        private bool Kill()
        {
            try
            {
                String username = WindowsIdentity.GetCurrent().Name;
                foreach (var process in Process.GetProcessesByName("App"))
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ProcessID = " + process.Id);
                    ManagementObjectCollection processList = searcher.Get();

                    foreach (ManagementObject obj in processList)
                    {
                        string[] argList = new string[] { string.Empty, string.Empty };
                        int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                        if (returnVal == 0)
                        {
                            if (argList[1] + "\\" + argList[0] == username)
                            {
                                process.Kill();
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                CMDprintError("清理游戏进程异常");
                return false;
            }
        }

#endregion

#region CMD
        public void CMDprint(string value)
        {
            string log = string.Format("[{0}]{1}\r\n", DateTime.Now.ToLongTimeString(), value);
            try
            {
                CmdrichTextBox.AppendText(log);
            }
            catch (Exception e)
            {
                this.Invoke(new Action(delegate 
                {
                    CmdrichTextBox.AppendText(log);
                }));
            }
        }
        public void CMDprintError(string value)
        {
            string log = string.Format("[{0}][Error]{1}\r\n", DateTime.Now.ToLongTimeString(), value);
            try
            {
                CmdrichTextBox.AppendText(log);
            }
            catch (Exception e)
            {
                this.Invoke(new Action(delegate 
                {
                    CmdrichTextBox.AppendText(log);
                }));
            }
        }

        private void CmdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8是退格13回车38方向键上
            if (e.KeyChar == (char)13 && !string.IsNullOrEmpty(CmdtextBox.Text))
            {
                e.Handled = true;
                CMDprint(chelp.CheckKey(CmdtextBox.Text));
                tmpcmd = CmdtextBox.Text;
                CmdtextBox.Clear();
            }
        }

        private void CmdtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (!string.IsNullOrEmpty(tmpcmd))
                    CmdtextBox.Text = tmpcmd;
            }
        }
#endregion

#region 处理源码
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            GetIDName getidname;
            if (scrtextBox.Text.Length == 0)
            {
                if(string.IsNullOrWhiteSpace(ClipboardText))
                {
                    MessageBox.Show("请复制徽章页面的源代码!", "错误");
                }
                else
                {
                    getidname = new GetIDName(ClipboardText);
                    getidname.Badlist = config.Blacklist;
                    e.Result = getidname.Getid();
                }
            }
            else
            {
                getidname = new GetIDName(scrtextBox.Text);
                getidname.Badlist = config.Blacklist;
                e.Result = getidname.Getid();
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                Console.WriteLine("You canceled!");
            else if (e.Error != null)
                Console.WriteLine("Worker exception: " + e.Error.ToString());
            else
            {
                List<AppMember> tmp = (List<AppMember>)e.Result;
                LoadAppData(tmp);
            }
        }

        private void LoadAppData(List<AppMember> member)
        {
            applist = member;
            applistView.Items.Clear();
            if (member != null && member.Count > 0)
            {
                for (int i = 0; i < member.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = member[i].Id;
                    lvi.SubItems.Add(member[i].Name);
                    lvi.SubItems.Add(member[i].CardNum);
                    lvi.SubItems.Add(member[i].Time);
                    applistView.Items.Add(lvi);
                }
            }
        }

#endregion

#region 自动更新
        public void checkUpdate()
        {
            if (string.IsNullOrEmpty(config.UpdateUrl))
                config.UpdateUrl = updateUrl;

            SoftUpdate app = new SoftUpdate(config.UpdateUrl, Application.ExecutablePath, "zha7idle");
            try
            {               
                if (app.IsUpdate && MessageBox.Show(string.Format("检查到新版本{0}，是否更新？\r\n更新说明:\r\n{1}", app.NewVerson, app.UpdateHelp), "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    upform = new UpdateForm(app);
                    upform.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        #endregion
    }
}
