using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace idleApp
{
    public partial class MyMessageForm : Form
    {
        public enum MessageButton
        {
            OK = 0,
            YesNo = 1
        }

        static private DialogResult mReturnButton;

        public MyMessageForm()
        {
            InitializeComponent();
        }

        private void BuildForm(string message, string caption, MessageButton buttons)
        {
            if (buttons == MessageButton.OK)
            {
                okButton.Visible = true;
                yesButton.Visible = false;
                noButton.Visible = false;
            }
            else if (buttons == MessageButton.YesNo)
            {
                okButton.Visible = false;
                yesButton.Visible = true;
                noButton.Visible = true;
            }
            this.Text = caption;
            MatchEvaluator me = delegate (Match m)
            {
                return "\r\n";
            };
            string rep = Regex.Replace(message, @"\\r\\n", me);
            msgRichTextBox.Text = string.Format("{0}", rep);
        }

        /// <summary>
        /// 显示消息窗体
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="caption">标题</param>
        /// <param name="buttons">按钮类型</param>
        /// <returns></returns>
        public DialogResult Show(string message, string caption, MessageButton buttons)
        {
            BuildForm(message, caption, buttons);
            this.ShowDialog();
            return mReturnButton;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            mReturnButton = DialogResult.Yes;
            this.Dispose();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            mReturnButton = DialogResult.OK;
            this.Dispose();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            mReturnButton = DialogResult.OK;
            this.Dispose();
        }
    }
}
