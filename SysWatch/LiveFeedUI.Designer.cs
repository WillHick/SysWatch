
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
            this.components = new System.ComponentModel.Container();
            this.SysWatchLiveFeed = new System.IO.FileSystemWatcher();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.FeedHeader = new System.Windows.Forms.Label();
            this.UIHeader = new System.Windows.Forms.Label();
            this.FeedClear = new System.Windows.Forms.Timer(this.components);
            this.HideFeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeed)).BeginInit();
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
            this.Output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(0, 58);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(779, 399);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // FeedHeader
            // 
            this.FeedHeader.AutoSize = true;
            this.FeedHeader.Font = new System.Drawing.Font("Microsoft YaHei", 7F, System.Drawing.FontStyle.Bold);
            this.FeedHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.FeedHeader.Location = new System.Drawing.Point(129, 24);
            this.FeedHeader.Name = "FeedHeader";
            this.FeedHeader.Size = new System.Drawing.Size(180, 19);
            this.FeedHeader.TabIndex = 3;
            this.FeedHeader.Text = "Live Feed Beta (Remake)";
            // 
            // UIHeader
            // 
            this.UIHeader.AutoSize = true;
            this.UIHeader.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIHeader.ForeColor = System.Drawing.Color.White;
            this.UIHeader.Location = new System.Drawing.Point(14, 14);
            this.UIHeader.Name = "UIHeader";
            this.UIHeader.Size = new System.Drawing.Size(121, 30);
            this.UIHeader.TabIndex = 2;
            this.UIHeader.Text = "SysWatch";
            // 
            // FeedClear
            // 
            this.FeedClear.Interval = 2000;
            this.FeedClear.Tick += new System.EventHandler(this.FeedClear_Tick);
            // 
            // HideFeed
            // 
            this.HideFeed.AutoSize = true;
            this.HideFeed.Font = new System.Drawing.Font("NSimSun", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideFeed.ForeColor = System.Drawing.Color.White;
            this.HideFeed.Location = new System.Drawing.Point(732, 13);
            this.HideFeed.Name = "HideFeed";
            this.HideFeed.Size = new System.Drawing.Size(33, 34);
            this.HideFeed.TabIndex = 4;
            this.HideFeed.Text = ">";
            this.HideFeed.Click += new System.EventHandler(this.HideFeed_Click);
            // 
            // LiveFeedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(778, 456);
            this.ControlBox = false;
            this.Controls.Add(this.HideFeed);
            this.Controls.Add(this.FeedHeader);
            this.Controls.Add(this.UIHeader);
            this.Controls.Add(this.Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LiveFeedUI";
            this.Opacity = 0.9D;
            this.Text = "SysWatch - Live Feed";
            this.Load += new System.EventHandler(this.LiveFeedUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher SysWatchLiveFeed;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label FeedHeader;
        private System.Windows.Forms.Label UIHeader;
        private System.Windows.Forms.Timer FeedClear;
        private System.Windows.Forms.Label HideFeed;
    }
}