
namespace SysWatch
{
    partial class LiveFeedUI
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
            this.SysWatchLiveFeed = new System.IO.FileSystemWatcher();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.TSBase = new System.Windows.Forms.MenuStrip();
            this.TSClear = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCloseFeed = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSIncrease = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDecrease = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSettings = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeed)).BeginInit();
            this.TSBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // SysWatchLiveFeed
            // 
            this.SysWatchLiveFeed.EnableRaisingEvents = true;
            this.SysWatchLiveFeed.SynchronizingObject = this;
            this.SysWatchLiveFeed.Changed += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Changed);
            this.SysWatchLiveFeed.Created += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Created);
            this.SysWatchLiveFeed.Deleted += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Deleted);
            this.SysWatchLiveFeed.Renamed += new System.IO.RenamedEventHandler(this.SysWatchLiveFeed_Renamed);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.DetectUrls = false;
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(964, 606);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // TSBase
            // 
            this.TSBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TSBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSBase.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.TSBase.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TSBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSClear,
            this.TSSettings,
            this.TSCloseFeed});
            this.TSBase.Location = new System.Drawing.Point(0, 606);
            this.TSBase.Name = "TSBase";
            this.TSBase.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TSBase.Size = new System.Drawing.Size(964, 36);
            this.TSBase.TabIndex = 1;
            this.TSBase.Text = "menuStrip1";
            // 
            // TSClear
            // 
            this.TSClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TSClear.ForeColor = System.Drawing.Color.White;
            this.TSClear.Name = "TSClear";
            this.TSClear.Size = new System.Drawing.Size(72, 32);
            this.TSClear.Text = "Clear";
            this.TSClear.Click += new System.EventHandler(this.TSClear_Click);
            // 
            // TSCloseFeed
            // 
            this.TSCloseFeed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TSCloseFeed.ForeColor = System.Drawing.Color.White;
            this.TSCloseFeed.Name = "TSCloseFeed";
            this.TSCloseFeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TSCloseFeed.Size = new System.Drawing.Size(122, 32);
            this.TSCloseFeed.Text = "Close Feed";
            this.TSCloseFeed.Click += new System.EventHandler(this.TSCloseFeed_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSIncrease,
            this.TSDecrease});
            this.textToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.textToolStripMenuItem.Text = "Text Size";
            // 
            // TSIncrease
            // 
            this.TSIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TSIncrease.ForeColor = System.Drawing.Color.White;
            this.TSIncrease.Name = "TSIncrease";
            this.TSIncrease.Size = new System.Drawing.Size(270, 36);
            this.TSIncrease.Text = "Increase";
            this.TSIncrease.Click += new System.EventHandler(this.TSIncrease_Click);
            // 
            // TSDecrease
            // 
            this.TSDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TSDecrease.ForeColor = System.Drawing.Color.White;
            this.TSDecrease.Name = "TSDecrease";
            this.TSDecrease.Size = new System.Drawing.Size(270, 36);
            this.TSDecrease.Text = "Decrease";
            this.TSDecrease.Click += new System.EventHandler(this.TSDecrease_Click);
            // 
            // TSSettings
            // 
            this.TSSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem});
            this.TSSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TSSettings.ForeColor = System.Drawing.Color.White;
            this.TSSettings.Name = "TSSettings";
            this.TSSettings.Size = new System.Drawing.Size(99, 32);
            this.TSSettings.Text = "Settings";
            // 
            // LiveFeedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(964, 642);
            this.ControlBox = false;
            this.Controls.Add(this.Output);
            this.Controls.Add(this.TSBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.TSBase;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LiveFeedUI";
            this.Opacity = 0.9D;
            this.Text = "SysWatch - Live Feed";
            this.Load += new System.EventHandler(this.LiveFeedUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeed)).EndInit();
            this.TSBase.ResumeLayout(false);
            this.TSBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher SysWatchLiveFeed;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.MenuStrip TSBase;
        private System.Windows.Forms.ToolStripMenuItem TSClear;
        private System.Windows.Forms.ToolStripMenuItem TSCloseFeed;
        private System.Windows.Forms.ToolStripMenuItem TSSettings;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSIncrease;
        private System.Windows.Forms.ToolStripMenuItem TSDecrease;
    }
}