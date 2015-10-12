using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace idleApp
{
    class RunApp
    {
        private System.Diagnostics.Process gameApp;
        string mArguments;
        Timer appTimer;
        List<AppMember> list;
        public bool Enabled = false;
        int mIndex = 0;
        int time;

        #region 属性
        public List<AppMember> List
        {
            set
            {
                list = value;
            }
        }

        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public bool InIdle { get { return gameApp != null && !gameApp.HasExited; } }

        #endregion

        public RunApp()
        {

        }
        ///<summary>
        ///开始
        ///</summary>
        public void Run()
        {
            int card = Convert.ToInt32(list[0].CardNum);
#if DEBUG
            //20s
            int tmp_time = 10 * 1000;
            appTimer = new Timer(tmp_time);
#endif
#if !DEBUG
            //20min
            int tmp_time = time * 60 * 1000;
			appTimer = new Timer(tmp_time * card);
#endif
            StartApp();
            StartTimer();
        }
        ///<summary>
        ///结束
        ///</summary>
        public void Stop()
        {
            StopTimer();
        }

        //============================================================================
        //私有方法
        //============================================================================
        private void StartTimer()
        {
            appTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            appTimer.Enabled = true;
        }

        private void StopTimer()
        {
            StopApp();
            if (appTimer != null)
            {
                appTimer.Stop();
                appTimer.Close();
                Enabled = false;
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                list.RemoveAt(0);
                StopApp();
                System.Diagnostics.Debug.WriteLine(mIndex);
                if (list.Count != 0)
                {
                    StartApp();
                }
                else
                {
                    setLog(DateTime.Now.ToString(), "End", mArguments);
                }
            }
            catch (Exception e_indexout)
            {
                StopApp();
                setLog(DateTime.Now.ToString(), "End", mArguments);
            }
        }

        private void StartApp()
        {
            //if(InIdle)
            //{
            gameApp = new System.Diagnostics.Process();
            gameApp.StartInfo.UseShellExecute = true;
            gameApp.StartInfo.CreateNoWindow = true;
            gameApp.StartInfo.FileName = "App.exe";
            gameApp.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            mArguments = list[0].Id;
            gameApp.StartInfo.Arguments = mArguments;
            gameApp.Start();

            setLog(gameApp.StartTime.ToString(), "Start", mArguments);
            Enabled = true;
            //}
        }
        private void StopApp()
        {
            if (InIdle)
            {
                gameApp.Kill();
                setLog(DateTime.Now.ToString(), "Exit", mArguments);
                Enabled = false;
            }
        }

        //uiDelegate
        public delegate void uiDelegate(string time, string status, string id);

        public uiDelegate mainThread;

        private void setLog(string time, string status, string id)
        {
            mainThread(time, status, id);
        }
    }
}
