using idleApp.Properties;
using System;
using System.Diagnostics;
using System.Text;

namespace idleApp.Class
{
    class SingleRun
    {
        private int virtualcard = 0;
        private AppMember App;

        public int Virtualcard
        {
            get
            {
                return virtualcard;
            }

            set
            {
                virtualcard = value;
            }
        }

        public SingleRun(AppMember app)
        {
            App = app;
            virtualcard = int.Parse(app.CardNum);
        }

        private Process gameApp;

        public bool InIdle { get { return gameApp != null && !gameApp.HasExited; } }


        public Process StartApp()
        {
            if (InIdle)
                return gameApp;

            gameApp = new System.Diagnostics.Process();
            gameApp.StartInfo.UseShellExecute = true;
            gameApp.StartInfo.CreateNoWindow = true;
            gameApp.StartInfo.FileName = "App.exe";
            gameApp.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StringBuilder mArguments = new StringBuilder();
            mArguments.AppendFormat("{0} {1}", App.Id, ToBase64(App.Name));
            gameApp.StartInfo.Arguments = mArguments.ToString();

            try
            {
                gameApp.Start();
                Settings.Default.AppEnabled = true;
            }
            catch
            {
                throw new Exception("程序启动被阻止,请检查是否被安全软件阻拦");
                StopApp();
            }

            return gameApp;
        }

        public Process StartTwoApp()
        {
            if (InIdle)
                return gameApp;

            gameApp = new Process();
            gameApp.StartInfo.UseShellExecute = true;
            gameApp.StartInfo.CreateNoWindow = true;
            gameApp.StartInfo.FileName = "App.exe";
            StringBuilder mArguments = new StringBuilder();
            mArguments.AppendFormat("{0} {1}", App.Id, ToBase64(App.Name));
            gameApp.StartInfo.Arguments = mArguments.ToString();

            try
            {
                gameApp.Start();
                Settings.Default.AppEnabled = true;
            }
            catch
            {
                throw new Exception("程序启动被阻止,请检查是否被安全软件阻拦");
                StopApp();
            }

            return gameApp;
        }

        public void StopApp()
        {
            try
            {
                Settings.Default.AppEnabled = false;
                gameApp.Kill();
                gameApp.Close();
            }
            catch
            {
                //throw new Exception("结束异常,请检查是否被安全软件阻拦");
            }
        }

        private string ToBase64(string value)
        {
            string base64name = value;
            byte[] messageByte = Encoding.UTF8.GetBytes(base64name);
            base64name = Convert.ToBase64String(messageByte);
            return base64name;
        }
    }
}
