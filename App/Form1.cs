using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                nameLabel.Text = args[1];
                this.Text = args[1];
            }
            catch (Exception e)
            {
                //this.Text = args[0];
            }
        }
    }
}
