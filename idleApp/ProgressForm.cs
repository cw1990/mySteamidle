using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace idleApp
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void ChageProgress(int progress)
        {
            progressBar1.Value = progress;
        }

        private void ChageState(string state)
        {
            state_label.Text = state;
        }

        private void ChageMax(int max)
        {
            progressBar1.Maximum = max;
        }

        /// <summary>
        /// 进度条Value
        /// </summary>
        public int Progress
        {
            set
            {
                ChageProgress(value);
            }
        }

        /// <summary>
        /// 进度条Max
        /// </summary>
        public int SetProgressMax
        {
            set
            {
                ChageMax(value);
            }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public string State
        {
            set
            {
                ChageState(value);
            }
        }
    }
}
