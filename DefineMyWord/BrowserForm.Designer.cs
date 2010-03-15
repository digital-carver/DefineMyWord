namespace DefineMyWord
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.definitionBrowser = new System.Windows.Forms.WebBrowser();
            this.goButton = new System.Windows.Forms.PictureBox();
            this.addressBar = new System.Windows.Forms.ComboBox();
            this.systrayNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTrayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goButton)).BeginInit();
            this.sysTrayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // definitionBrowser
            // 
            this.definitionBrowser.Location = new System.Drawing.Point(0, 30);
            this.definitionBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.definitionBrowser.Name = "definitionBrowser";
            this.definitionBrowser.Size = new System.Drawing.Size(784, 514);
            this.definitionBrowser.TabIndex = 0;
            this.definitionBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.definitionBrowser_Navigating);
            // 
            // goButton
            // 
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.Location = new System.Drawing.Point(759, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(13, 19);
            this.goButton.TabIndex = 2;
            this.goButton.TabStop = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // addressBar
            // 
            this.addressBar.FormattingEnabled = true;
            this.addressBar.Location = new System.Drawing.Point(0, 2);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(753, 21);
            this.addressBar.TabIndex = 3;
            this.addressBar.SelectedIndexChanged += new System.EventHandler(this.addressBar_SelectedIndexChanged);
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // systrayNotifyIcon
            // 
            this.systrayNotifyIcon.ContextMenuStrip = this.sysTrayMenuStrip;
            this.systrayNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systrayNotifyIcon.Icon")));
            this.systrayNotifyIcon.Text = "DefineMyWord";
            this.systrayNotifyIcon.Visible = true;
            this.systrayNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sysTrayNotifyIcon_MouseDoubleClick);
            // 
            // sysTrayMenuStrip
            // 
            this.sysTrayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreMenuItem,
            this.exitMenuItem});
            this.sysTrayMenuStrip.Name = "sysTrayMenuStrip";
            this.sysTrayMenuStrip.Size = new System.Drawing.Size(187, 48);
            // 
            // restoreMenuItem
            // 
            this.restoreMenuItem.Name = "restoreMenuItem";
            this.restoreMenuItem.Size = new System.Drawing.Size(186, 22);
            this.restoreMenuItem.Text = "Open DefineMyWord";
            this.restoreMenuItem.Click += new System.EventHandler(this.restoreMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitMenuItem.Text = "Exit DefineMyWord";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // miniButton
            // 
            this.miniButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.miniButton.Location = new System.Drawing.Point(761, 27);
            this.miniButton.Name = "miniButton";
            this.miniButton.Size = new System.Drawing.Size(23, 23);
            this.miniButton.TabIndex = 4;
            this.miniButton.Text = "-";
            this.miniButton.UseVisualStyleBackColor = true;
            this.miniButton.Visible = false;
            this.miniButton.Click += new System.EventHandler(this.miniButton_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.miniButton;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.miniButton);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.definitionBrowser);
            this.KeyPreview = true;
            this.Name = "BrowserForm";
            this.ShowInTaskbar = false;
            this.Text = "DefineMyWord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BrowserForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowserForm_FormClosing);
            this.Resize += new System.EventHandler(this.BrowserForm_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrowserForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.goButton)).EndInit();
            this.sysTrayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser definitionBrowser;
        private System.Windows.Forms.PictureBox goButton;
        private System.Windows.Forms.ComboBox addressBar;
        private System.Windows.Forms.NotifyIcon systrayNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip sysTrayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreMenuItem;
        private System.Windows.Forms.Button miniButton;
    }
}

