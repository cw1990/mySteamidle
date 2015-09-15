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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.backlistView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backAddButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backDelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.regexIDtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regCardtextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.getIDToolStripMenuItem,
            this.dELToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.helpToolStripMenuItem.Text = "帮助(重要)";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.columnHeader3});
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
            this.columnHeader3.Width = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(510, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "控制台";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // backlistView
            // 
            this.backlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.backlistView.FullRowSelect = true;
            this.backlistView.GridLines = true;
            this.backlistView.Location = new System.Drawing.Point(6, 20);
            this.backlistView.Name = "backlistView";
            this.backlistView.Size = new System.Drawing.Size(120, 249);
            this.backlistView.TabIndex = 1;
            this.backlistView.UseCompatibleStateImageBehavior = false;
            this.backlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.regCardtextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.regexIDtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(141, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "正则表达式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backDelButton);
            this.groupBox2.Controls.Add(this.backAddButton);
            this.groupBox2.Controls.Add(this.backlistView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 304);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "黑名单";
            // 
            // backAddButton
            // 
            this.backAddButton.Location = new System.Drawing.Point(6, 275);
            this.backAddButton.Name = "backAddButton";
            this.backAddButton.Size = new System.Drawing.Size(60, 25);
            this.backAddButton.TabIndex = 2;
            this.backAddButton.Text = "Add";
            this.backAddButton.UseVisualStyleBackColor = true;
            // 
            // backDelButton
            // 
            this.backDelButton.Location = new System.Drawing.Point(66, 275);
            this.backDelButton.Name = "backDelButton";
            this.backDelButton.Size = new System.Drawing.Size(60, 25);
            this.backDelButton.TabIndex = 3;
            this.backDelButton.Text = "Del";
            this.backDelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "获取ID用";
            // 
            // regexIDtextBox
            // 
            this.regexIDtextBox.Location = new System.Drawing.Point(6, 36);
            this.regexIDtextBox.Name = "regexIDtextBox";
            this.regexIDtextBox.Size = new System.Drawing.Size(188, 21);
            this.regexIDtextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "获取Card数量用";
            // 
            // regCardtextBox
            // 
            this.regCardtextBox.Location = new System.Drawing.Point(6, 80);
            this.regCardtextBox.Name = "regCardtextBox";
            this.regCardtextBox.Size = new System.Drawing.Size(188, 21);
            this.regCardtextBox.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(141, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 188);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置";
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
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(134, 17);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(60, 21);
            this.timeTextBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.helpTextBox);
            this.groupBox4.Location = new System.Drawing.Point(347, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 304);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "帮助";
            // 
            // helpTextBox
            // 
            this.helpTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpTextBox.Location = new System.Drawing.Point(3, 17);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.Size = new System.Drawing.Size(149, 284);
            this.helpTextBox.TabIndex = 0;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
        private System.Windows.Forms.Button backAddButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button backDelButton;
        private System.Windows.Forms.TextBox regCardtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regexIDtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox helpTextBox;
    }
}

