using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();
            try
            {
                idLabel.Text = args[0];
                byte[] bytes = Convert.FromBase64String(args[1]);
                string name = Encoding.Default.GetString(bytes);
                nameLabel.Text = name;
                this.Text = name;
            }
            catch (Exception)
            {
                try
                {
                    this.Text = args[0];
                }
                catch { this.Text = "Debug"; };
            }
        }
    }
}
