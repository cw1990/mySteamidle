namespace idleApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Snumlabel = new System.Windows.Forms.Label();
            this.clearTextbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.scrtextBox = new System.Windows.Forms.TextBox();
            this.timelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picApp = new System.Windows.Forms.PictureBox();
            this.game_label = new System.Windows.Forms.Label();
            this.applistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.helpRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blackTextBox = new System.Windows.Forms.TextBox();
            this.blackDelButton = new System.Windows.Forms.Button();
            this.blackAddButton = new System.Windows.Forms.Button();
            this.backlistView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CmdtextBox = new System.Windows.Forms.TextBox();
            this.CmdrichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.twohourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.getIDToolStripMenuItem,
            this.dELToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.twohourToolStripMenuItem,
            this.clearAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.startToolStripMenuItem.Text = "开始";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // getIDToolStripMenuItem
            // 
            this.getIDToolStripMenuItem.Name = "getIDToolStripMenuItem";
            this.getIDToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.getIDToolStripMenuItem.Text = "获取ID";
            this.getIDToolStripMenuItem.Click += new System.EventHandler(this.getIDToolStripMenuItem_Click);
            // 
            // dELToolStripMenuItem
            // 
            this.dELToolStripMenuItem.Name = "dELToolStripMenuItem";
            this.dELToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.dELToolStripMenuItem.Text = "删除选中项";
            this.dELToolStripMenuItem.Click += new System.EventHandler(this.dELToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 336);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Snumlabel);
            this.tabPage1.Controls.Add(this.clearTextbutton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.scrtextBox);
            this.tabPage1.Controls.Add(this.timelabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.picApp);
            this.tabPage1.Controls.Add(this.game_label);
            this.tabPage1.Controls.Add(this.applistView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "本体";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Snumlabel
            // 
            this.Snumlabel.AutoSize = true;
            this.Snumlabel.Location = new System.Drawing.Point(329, 151);
            this.Snumlabel.Name = "Snumlabel";
            this.Snumlabel.Size = new System.Drawing.Size(35, 12);
            this.Snumlabel.TabIndex = 20;
            this.Snumlabel.Text = "SNum:";
            // 
            // clearTextbutton
            // 
            this.clearTextbutton.Location = new System.Drawing.Point(329, 115);
            this.clearTextbutton.Name = "clearTextbutton";
            this.clearTextbutton.Size = new System.Drawing.Size(175, 23);
            this.clearTextbutton.TabIndex = 19;
            this.clearTextbutton.Text = "清除上方源码";
            this.clearTextbutton.UseVisualStyleBackColor = true;
            this.clearTextbutton.Click += new System.EventHandler(this.clearTextbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "请粘贴源码至下面方框中";
            // 
            // scrtextBox
            // 
            this.scrtextBox.Location = new System.Drawing.Point(329, 29);
            this.scrtextBox.MaxLength = 999999999;
            this.scrtextBox.Multiline = true;
            this.scrtextBox.Name = "scrtextBox";
            this.scrtextBox.Size = new System.Drawing.Size(175, 80);
            this.scrtextBox.TabIndex = 17;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(329, 216);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(35, 12);
            this.timelabel.TabIndex = 16;
            this.timelabel.Text = "Loacl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "In:";
            // 
            // picApp
            // 
            this.picApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picApp.Location = new System.Drawing.Point(323, 238);
            this.picApp.MaximumSize = new System.Drawing.Size(184, 69);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(184, 69);
            this.picApp.TabIndex = 14;
            this.picApp.TabStop = false;
            // 
            // game_label
            // 
            this.game_label.AutoSize = true;
            this.game_label.Location = new System.Drawing.Point(329, 195);
            this.game_label.Name = "game_label";
            this.game_label.Size = new System.Drawing.Size(29, 12);
            this.game_label.TabIndex = 13;
            this.game_label.Text = "Null";
            // 
            // applistView
            // 
            this.applistView.BackColor = System.Drawing.Color.White;
            this.applistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.applistView.Dock = System.Windows.Forms.DockStyle.Left;
            this.applistView.FullRowSelect = true;
            this.applistView.GridLines = true;
            this.applistView.Location = new System.Drawing.Point(3, 3);
            this.applistView.MultiSelect = false;
            this.applistView.Name = "applistView";
            this.applistView.Size = new System.Drawing.Size(320, 304);
            this.applistView.TabIndex = 12;
            this.applistView.UseCompatibleStateImageBehavior = false;
            this.applistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Card";
            this.columnHeader3.Width = 46;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Horus";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.helpRichTextBox);
            this.groupBox4.Location = new System.Drawing.Point(347, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 304);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "帮助";
            // 
            // helpRichTextBox
            // 
            this.helpRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpRichTextBox.Location = new System.Drawing.Point(3, 17);
            this.helpRichTextBox.Name = "helpRichTextBox";
            this.helpRichTextBox.ReadOnly = true;
            this.helpRichTextBox.Size = new System.Drawing.Size(149, 284);
            this.helpRichTextBox.TabIndex = 0;
            this.helpRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(141, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 304);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(134, 17);
            this.timeTextBox.MaxLength = 5;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(60, 21);
            this.timeTextBox.TabIndex = 1;
            this.timeTextBox.TextChanged += new System.EventHandler(this.timeTextBox_TextChanged);
            this.timeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "每张卡所需时间(分钟)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blackTextBox);
            this.groupBox2.Controls.Add(this.blackDelButton);
            this.groupBox2.Controls.Add(this.blackAddButton);
            this.groupBox2.Controls.Add(this.backlistView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 304);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "黑名单";
            // 
            // blackTextBox
            // 
            this.blackTextBox.Location = new System.Drawing.Point(6, 252);
            this.blackTextBox.Name = "blackTextBox";
            this.blackTextBox.Size = new System.Drawing.Size(120, 21);
            this.blackTextBox.TabIndex = 4;
            this.blackTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blackTextBox_KeyPress);
            // 
            // blackDelButton
            // 
            this.blackDelButton.Location = new System.Drawing.Point(66, 275);
            this.blackDelButton.Name = "blackDelButton";
            this.blackDelButton.Size = new System.Drawing.Size(60, 25);
            this.blackDelButton.TabIndex = 3;
            this.blackDelButton.Text = "Del";
            this.blackDelButton.UseVisualStyleBackColor = true;
            this.blackDelButton.Click += new System.EventHandler(this.blackDelButton_Click);
            // 
            // blackAddButton
            // 
            this.blackAddButton.Location = new System.Drawing.Point(6, 275);
            this.blackAddButton.Name = "blackAddButton";
            this.blackAddButton.Size = new System.Drawing.Size(60, 25);
            this.blackAddButton.TabIndex = 2;
            this.blackAddButton.Text = "Add";
            this.blackAddButton.UseVisualStyleBackColor = true;
            this.blackAddButton.Click += new System.EventHandler(this.blackAddButton_Click);
            // 
            // backlistView
            // 
            this.backlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.backlistView.FullRowSelect = true;
            this.backlistView.GridLines = true;
            this.backlistView.Location = new System.Drawing.Point(6, 20);
            this.backlistView.MultiSelect = false;
            this.backlistView.Name = "backlistView";
            this.backlistView.Size = new System.Drawing.Size(120, 226);
            this.backlistView.TabIndex = 1;
            this.backlistView.UseCompatibleStateImageBehavior = false;
            this.backlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 110;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.CmdrichTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(510, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "控制台";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CmdtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 25);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = ">";
            // 
            // CmdtextBox
            // 
            this.CmdtextBox.BackColor = System.Drawing.Color.Black;
            this.CmdtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CmdtextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmdtextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmdtextBox.ForeColor = System.Drawing.Color.White;
            this.CmdtextBox.Location = new System.Drawing.Point(19, 0);
            this.CmdtextBox.Name = "CmdtextBox";
            this.CmdtextBox.Size = new System.Drawing.Size(491, 19);
            this.CmdtextBox.TabIndex = 1;
            this.CmdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmdtextBox_KeyPress);
            this.CmdtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmdtextBox_KeyUp);
            // 
            // CmdrichTextBox
            // 
            this.CmdrichTextBox.BackColor = System.Drawing.Color.Black;
            this.CmdrichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CmdrichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdrichTextBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmdrichTextBox.ForeColor = System.Drawing.Color.White;
            this.CmdrichTextBox.Location = new System.Drawing.Point(0, 0);
            this.CmdrichTextBox.Name = "CmdrichTextBox";
            this.CmdrichTextBox.ReadOnly = true;
            this.CmdrichTextBox.Size = new System.Drawing.Size(510, 279);
            this.CmdrichTextBox.TabIndex = 0;
            this.CmdrichTextBox.Text = "";
            this.CmdrichTextBox.TextChanged += new System.EventHandler(this.CmdrichTextBox_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // twohourToolStripMenuItem
            // 
            this.twohourToolStripMenuItem.Name = "twohourToolStripMenuItem";
            this.twohourToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.twohourToolStripMenuItem.Text = "一键挂2小时";
            this.twohourToolStripMenuItem.Click += new System.EventHandler(this.twohourToolStripMenuItem_Click);
            // 
            // clearAppToolStripMenuItem
            // 
            this.clearAppToolStripMenuItem.Name = "clearAppToolStripMenuItem";
            this.clearAppToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.clearAppToolStripMenuItem.Text = "一键关闭游戏";
            this.clearAppToolStripMenuItem.Click += new System.EventHandler(this.clearAppToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(534, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Snumlabel;
        private System.Windows.Forms.Button clearTextbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scrtextBox;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picApp;
        private System.Windows.Forms.Label game_label;
        private System.Windows.Forms.ListView applistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView backlistView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button blackAddButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button blackDelButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox helpRichTextBox;
        private System.Windows.Forms.TextBox blackTextBox;
        private System.Windows.Forms.TextBox CmdtextBox;
        private System.Windows.Forms.RichTextBox CmdrichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem twohourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAppToolStripMenuItem;
    }
}

