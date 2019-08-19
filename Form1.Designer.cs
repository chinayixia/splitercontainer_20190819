namespace wf_foh100_demotool_release
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_menubar = new System.Windows.Forms.Panel();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.panel_notifyIcon = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.userControl_shrink = new wf_foh100_demotool_release.UserControl_menubar();
            this.userControl_minimize = new wf_foh100_demotool_release.UserControl_menubar();
            this.userControl_grow = new wf_foh100_demotool_release.UserControl_menubar();
            this.userControl_close1 = new wf_foh100_demotool_release.UserControl_menubar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerEx1 = new wf_foh100_demotool_release.SplitContainerEx();
            this.panel_menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.panel_notifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            this.splitContainerEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menubar
            // 
            this.panel_menubar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menubar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_menubar.BackColor = System.Drawing.Color.Transparent;
            this.panel_menubar.Controls.Add(this.pictureBox_icon);
            this.panel_menubar.Controls.Add(this.panel_notifyIcon);
            this.panel_menubar.Controls.Add(this.userControl_shrink);
            this.panel_menubar.Controls.Add(this.userControl_minimize);
            this.panel_menubar.Controls.Add(this.userControl_grow);
            this.panel_menubar.Controls.Add(this.userControl_close1);
            this.panel_menubar.Controls.Add(this.panel5);
            this.panel_menubar.Location = new System.Drawing.Point(0, 1);
            this.panel_menubar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menubar.Name = "panel_menubar";
            this.panel_menubar.Size = new System.Drawing.Size(800, 30);
            this.panel_menubar.TabIndex = 9;
            this.panel_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_menubar_MouseDown);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_icon.Image = global::wf_foh100_demotool_release.Properties.Resources.redman_t;
            this.pictureBox_icon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(20, 30);
            this.pictureBox_icon.TabIndex = 13;
            this.pictureBox_icon.TabStop = false;
            // 
            // panel_notifyIcon
            // 
            this.panel_notifyIcon.Controls.Add(this.label3);
            this.panel_notifyIcon.Location = new System.Drawing.Point(20, 0);
            this.panel_notifyIcon.Margin = new System.Windows.Forms.Padding(0);
            this.panel_notifyIcon.Name = "panel_notifyIcon";
            this.panel_notifyIcon.Size = new System.Drawing.Size(89, 30);
            this.panel_notifyIcon.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "T D";
            // 
            // userControl_shrink
            // 
            this.userControl_shrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_shrink.AutoScroll = true;
            this.userControl_shrink.BackColor = System.Drawing.Color.Transparent;
            this.userControl_shrink.Checked = true;
            this.userControl_shrink.CheckStyleX = wf_foh100_demotool_release.UserControl_menubar.CheckStyle.style3;
            this.userControl_shrink.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_shrink.Location = new System.Drawing.Point(710, 0);
            this.userControl_shrink.Name = "userControl_shrink";
            this.userControl_shrink.Size = new System.Drawing.Size(45, 30);
            this.userControl_shrink.TabIndex = 10;
            this.userControl_shrink.Visible = false;
            this.userControl_shrink.Click += new System.EventHandler(this.userControl_shrink_Click);
            // 
            // userControl_minimize
            // 
            this.userControl_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_minimize.AutoScroll = true;
            this.userControl_minimize.BackColor = System.Drawing.Color.Black;
            this.userControl_minimize.Checked = true;
            this.userControl_minimize.CheckStyleX = wf_foh100_demotool_release.UserControl_menubar.CheckStyle.style4;
            this.userControl_minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_minimize.Location = new System.Drawing.Point(665, 0);
            this.userControl_minimize.Name = "userControl_minimize";
            this.userControl_minimize.Size = new System.Drawing.Size(45, 30);
            this.userControl_minimize.TabIndex = 11;
            this.userControl_minimize.Click += new System.EventHandler(this.userControl_minimize_Click);
            // 
            // userControl_grow
            // 
            this.userControl_grow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_grow.BackColor = System.Drawing.Color.Transparent;
            this.userControl_grow.Checked = true;
            this.userControl_grow.CheckStyleX = wf_foh100_demotool_release.UserControl_menubar.CheckStyle.style2;
            this.userControl_grow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_grow.Location = new System.Drawing.Point(710, 0);
            this.userControl_grow.Name = "userControl_grow";
            this.userControl_grow.Size = new System.Drawing.Size(45, 30);
            this.userControl_grow.TabIndex = 10;
            this.userControl_grow.Click += new System.EventHandler(this.userControl_grow_Click);
            // 
            // userControl_close1
            // 
            this.userControl_close1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_close1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_close1.Checked = true;
            this.userControl_close1.CheckStyleX = wf_foh100_demotool_release.UserControl_menubar.CheckStyle.style1;
            this.userControl_close1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_close1.Location = new System.Drawing.Point(755, 0);
            this.userControl_close1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_close1.Name = "userControl_close1";
            this.userControl_close1.Size = new System.Drawing.Size(45, 30);
            this.userControl_close1.TabIndex = 9;
            this.userControl_close1.Click += new System.EventHandler(this.userControl_close1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoScroll = true;
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(851, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 0);
            this.panel5.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(135, 206, 250);      //change color to black
            this.splitContainer1.Location = new System.Drawing.Point(2, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = global::wf_foh100_demotool_release.Properties.Resources.backimage454548;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerEx1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(796, 418);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 10;
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.BackColor = System.Drawing.Color.SkyBlue;
            this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx1.Name = "splitContainerEx1";
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainerEx1.Panel1MinSize = 0;
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainerEx1.Panel2MinSize = 0;
            this.splitContainerEx1.Size = new System.Drawing.Size(796, 322);
            this.splitContainerEx1.SplitterDistance = 622;
            this.splitContainerEx1.SplitterWidth = 9;
            this.splitContainerEx1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wf_foh100_demotool_release.Properties.Resources.backimage454548;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_menubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOH-100";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menubar.ResumeLayout(false);
            this.panel_menubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.panel_notifyIcon.ResumeLayout(false);
            this.panel_notifyIcon.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel_menubar;
        private UserControl_menubar userControl_close1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private UserControl_menubar userControl_grow;
        private UserControl_menubar userControl_minimize;
        private UserControl_menubar userControl_shrink;
        private System.Windows.Forms.Panel panel_notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SplitContainerEx splitContainerEx1;
    }
}

