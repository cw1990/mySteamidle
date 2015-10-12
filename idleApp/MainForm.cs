using idleApp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using WebSocketSharp;

namespace idleApp
{
    public partial class MainForm : Form
    {
        List<AppMember> applist;
        RunApp runapp;
        //Client wbc;

        #region 常用参数
        string regexID = "(?<=\\brun/)\\w*\\b";
        string regexCard = "<span class=\"progress_info_bold\">([^<]*)</span>";
        int cardTime = 20;//分钟
        List<string> defBlackList = new List<string> { "303700", "368020", "335590", "267420" };
        Config config = new Config();
        #endregion

        BackgroundWorker _bw;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "卡牌小工具4.1.3 情怀版 By zha7";
            //初始化
            initializeConfig();

            runapp = new RunApp();
            runapp.mainThread += new RunApp.uiDelegate(LoadAppInfo);

            applist = new List<AppMember>();

            //int Snum = getRandomNum();
            //Snumlabel.Text = "SNum:" + Snum.ToString();
            //wbc = new Client(Snum);

            _bw = new BackgroundWorker();
            _bw.DoWork += bw_DoWork;
            _bw.RunWorkerCompleted += bw_RunWorkerCompleted;

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
        private void LoadAppInfo(string time, string status, string id)
        {
            switch (status)
            {
                case "Start":

                    this.Invoke(new Action(delegate { LoadAppImage(id); }));
                    UpdateForm(timelabel, time);

                    for (int i = 0; i < applist.Count; i++)
                    {
                        if (applist[i].Id == id)
                        {
                            UpdateForm(game_label, applist[i].Name);
                            return;
                        }

                    }
                    break;
                case "Exit":
                    UpdateForm(timelabel, "Null");
                    UpdateForm(game_label, "");
                    break;
                case "End":
                    UpdateForm(timelabel, "Null");
                    UpdateForm(game_label, "");
                    this.Invoke(new Action(delegate { LoadAppImage(status); }));
                    startToolStripMenuItem.Text = "开始";
                    applistView.Items.Clear();
                    break;
            }
        }

        /// <summary>
        /// 更新label
        /// </summary>
        /// <param name="label">label name</param>
        /// <param name="param">value</param>
        private void UpdateForm(Label label, string param)
        {
            this.Invoke(new Action(delegate { label.Text = param; }));
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
                    System.Console.WriteLine("Error From:" + e.TargetSite + " Message" + e.Message);
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

        private void getIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bw.RunWorkerAsync("Start to Get");
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (applist.Count != 0)
            {
                if (runapp.Enabled == false)
                {
                    runapp.List = applist;
                    runapp.Time = int.Parse(timeTextBox.Text);
                    runapp.Run();
                    startToolStripMenuItem.Text = "停止";
                }
                else
                {
                    runapp.Stop();
                    startToolStripMenuItem.Text = "开始";
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            runapp.Stop();
            string content = JsonHelper.SerializeObject(config);
            FileHelper.WriteFile("config.json", content);
        }

        private void clearTextbutton_Click(object sender, EventArgs e)
        {
            scrtextBox.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://zha7.bifidy.net");
        }

        private void dELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(applistView.SelectedItems.Count >0)
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
            if(blackTextBox.Text != "输入黑名单ID")
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
                MessageBox.Show("请复制徽章页面的源代码!", "错误");
                return null;
            }
        }

        /// <summary>
        /// 初始化参数
        /// </summary>
        private void initializeConfig()
        {
            string stream = FileHelper.ReadFile("config.json");
            if (!string.IsNullOrEmpty(stream) && stream != "Error")
            {
                config = JsonHelper.DeserializeJsonToObject<Config>(stream);
            }
            else
            {
                config = new Config();
                config.RegexID = regexID;
                config.RegexCard = regexCard;
                config.CardTime = cardTime;
                config.Blacklist = defBlackList;
            }
            initializeForm(config);
            HelpString help = new HelpString();
            helpRichTextBox.Text = help.ToString();
        }

        /// <summary>
        /// 初始化Form
        /// </summary>
        private void initializeForm(Config config)
        {
            blackTextBox.Text = "输入黑名单ID";
            regexIDtextBox.Text = config.RegexID;
            regCardtextBox.Text = config.RegexCard;
            timeTextBox.Text = config.CardTime.ToString();
            foreach (string value in config.Blacklist)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = value;
                backlistView.Items.Add(lvi);
            }
        }

        #endregion

        #region 处理源码
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            GetIDName getidname;          
            if (scrtextBox.Text.Length == 0)
            {
                string html = "";
                this.Invoke(new Action(delegate { html = getClipboard(); }));
                getidname = new GetIDName(html);
                getidname.RegexID = regexIDtextBox.Text;
                getidname.RegexCard = regCardtextBox.Text;
                getidname.Badlist = config.Blacklist;
                e.Result = getidname.Getid();// 这会传递给 RunWorkerCompleted
            }
            else
            {
                getidname = new GetIDName(scrtextBox.Text);
                getidname.RegexID = regexIDtextBox.Text;
                getidname.RegexCard = regCardtextBox.Text;
                getidname.Badlist = config.Blacklist;
                e.Result = getidname.Getid();
            }
        }

        private void bw_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
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
                    applistView.Items.Add(lvi);
                }
            }
        }
        #endregion
    }
}
