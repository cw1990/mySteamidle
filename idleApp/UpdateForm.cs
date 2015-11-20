using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Update;

namespace idleApp
{
    public partial class UpdateForm : Form
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="url">升级Url</param>
        public UpdateForm(SoftUpdate app)
        {
            InitializeComponent();
            this.Text = "更新中";

            //app = new SoftUpdate(url, Application.ExecutablePath, "zha7idle");
            app.UpdateFinish += new UpdateState(app_UpdateFinish);
            app.UpdateProgressChage += App_UpdateProgressChage;
            try
            {
                if (app.IsUpdate)
                {
                    Thread update = new Thread(new ThreadStart(app.Update));
                    update.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void App_UpdateProgressChage(int ProgressValue, string text)
        {
            this.Invoke(new Action(delegate
            {
                progressBar1.Value = ProgressValue;
                progressLabel.Text = text;
            }));
        }

        void app_UpdateFinish()
        {
            MessageBox.Show("更新完成，请解压更新包覆盖文件,然后重新启动程序！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Invoke(new Action(delegate
            {
                this.Close();
            }));
        }
    }
}
