
namespace SysWatch
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.SysWatchFile = new System.IO.FileSystemWatcher();
            this.UIHeader = new System.Windows.Forms.Label();
            this.BuildHeader = new System.Windows.Forms.Label();
            this.ChangedHeader = new System.Windows.Forms.Label();
            this.CreatedHeader = new System.Windows.Forms.Label();
            this.DeletedHeader = new System.Windows.Forms.Label();
            this.RenamedHeader = new System.Windows.Forms.Label();
            this.NumChanged = new System.Windows.Forms.Label();
            this.NumCreated = new System.Windows.Forms.Label();
            this.NumRename = new System.Windows.Forms.Label();
            this.NumDelete = new System.Windows.Forms.Label();
            this.CWHeader = new System.Windows.Forms.Label();
            this.WatchedLocation = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.Label();
            this.ResetCount = new System.Windows.Forms.Label();
            this.UIDash4 = new System.Windows.Forms.Label();
            this.UIDash3 = new System.Windows.Forms.Label();
            this.UIDash2 = new System.Windows.Forms.Label();
            this.UIDash1 = new System.Windows.Forms.Label();
            this.CopyStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchFile)).BeginInit();
            this.SuspendLayout();
            // 
            // SysWatchFile
            // 
            this.SysWatchFile.EnableRaisingEvents = true;
            this.SysWatchFile.IncludeSubdirectories = true;
            this.SysWatchFile.Path = "C:\\";
            this.SysWatchFile.SynchronizingObject = this;
            this.SysWatchFile.Changed += new System.IO.FileSystemEventHandler(this.SysWatch_Changed);
            this.SysWatchFile.Created += new System.IO.FileSystemEventHandler(this.SysWatch_Created);
            this.SysWatchFile.Deleted += new System.IO.FileSystemEventHandler(this.SysWatch_Deleted);
            this.SysWatchFile.Renamed += new System.IO.RenamedEventHandler(this.SysWatch_Renamed);
            // 
            // UIHeader
            // 
            this.UIHeader.AutoSize = true;
            this.UIHeader.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIHeader.ForeColor = System.Drawing.Color.White;
            this.UIHeader.Location = new System.Drawing.Point(14, 14);
            this.UIHeader.Name = "UIHeader";
            this.UIHeader.Size = new System.Drawing.Size(121, 30);
            this.UIHeader.TabIndex = 0;
            this.UIHeader.Text = "SysWatch";
            // 
            // BuildHeader
            // 
            this.BuildHeader.AutoSize = true;
            this.BuildHeader.Font = new System.Drawing.Font("Microsoft YaHei", 7F, System.Drawing.FontStyle.Bold);
            this.BuildHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BuildHeader.Location = new System.Drawing.Point(129, 24);
            this.BuildHeader.Name = "BuildHeader";
            this.BuildHeader.Size = new System.Drawing.Size(31, 19);
            this.BuildHeader.TabIndex = 1;
            this.BuildHeader.Text = "1.2";
            // 
            // ChangedHeader
            // 
            this.ChangedHeader.AutoSize = true;
            this.ChangedHeader.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.ChangedHeader.ForeColor = System.Drawing.Color.White;
            this.ChangedHeader.Location = new System.Drawing.Point(14, 59);
            this.ChangedHeader.Name = "ChangedHeader";
            this.ChangedHeader.Size = new System.Drawing.Size(92, 25);
            this.ChangedHeader.TabIndex = 2;
            this.ChangedHeader.Text = "Changed";
            // 
            // CreatedHeader
            // 
            this.CreatedHeader.AutoSize = true;
            this.CreatedHeader.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.CreatedHeader.ForeColor = System.Drawing.Color.White;
            this.CreatedHeader.Location = new System.Drawing.Point(14, 120);
            this.CreatedHeader.Name = "CreatedHeader";
            this.CreatedHeader.Size = new System.Drawing.Size(81, 25);
            this.CreatedHeader.TabIndex = 3;
            this.CreatedHeader.Text = "Created";
            // 
            // DeletedHeader
            // 
            this.DeletedHeader.AutoSize = true;
            this.DeletedHeader.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.DeletedHeader.ForeColor = System.Drawing.Color.White;
            this.DeletedHeader.Location = new System.Drawing.Point(14, 244);
            this.DeletedHeader.Name = "DeletedHeader";
            this.DeletedHeader.Size = new System.Drawing.Size(80, 25);
            this.DeletedHeader.TabIndex = 5;
            this.DeletedHeader.Text = "Deleted";
            // 
            // RenamedHeader
            // 
            this.RenamedHeader.AutoSize = true;
            this.RenamedHeader.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.RenamedHeader.ForeColor = System.Drawing.Color.White;
            this.RenamedHeader.Location = new System.Drawing.Point(14, 182);
            this.RenamedHeader.Name = "RenamedHeader";
            this.RenamedHeader.Size = new System.Drawing.Size(97, 25);
            this.RenamedHeader.TabIndex = 4;
            this.RenamedHeader.Text = "Renamed";
            // 
            // NumChanged
            // 
            this.NumChanged.AutoSize = true;
            this.NumChanged.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.NumChanged.ForeColor = System.Drawing.Color.White;
            this.NumChanged.Location = new System.Drawing.Point(31, 87);
            this.NumChanged.Name = "NumChanged";
            this.NumChanged.Size = new System.Drawing.Size(0, 25);
            this.NumChanged.TabIndex = 6;
            // 
            // NumCreated
            // 
            this.NumCreated.AutoSize = true;
            this.NumCreated.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.NumCreated.ForeColor = System.Drawing.Color.White;
            this.NumCreated.Location = new System.Drawing.Point(31, 148);
            this.NumCreated.Name = "NumCreated";
            this.NumCreated.Size = new System.Drawing.Size(0, 25);
            this.NumCreated.TabIndex = 7;
            // 
            // NumRename
            // 
            this.NumRename.AutoSize = true;
            this.NumRename.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.NumRename.ForeColor = System.Drawing.Color.White;
            this.NumRename.Location = new System.Drawing.Point(31, 210);
            this.NumRename.Name = "NumRename";
            this.NumRename.Size = new System.Drawing.Size(0, 25);
            this.NumRename.TabIndex = 8;
            // 
            // NumDelete
            // 
            this.NumDelete.AutoSize = true;
            this.NumDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.NumDelete.ForeColor = System.Drawing.Color.White;
            this.NumDelete.Location = new System.Drawing.Point(31, 272);
            this.NumDelete.Name = "NumDelete";
            this.NumDelete.Size = new System.Drawing.Size(0, 25);
            this.NumDelete.TabIndex = 9;
            // 
            // CWHeader
            // 
            this.CWHeader.AutoSize = true;
            this.CWHeader.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.CWHeader.ForeColor = System.Drawing.Color.White;
            this.CWHeader.Location = new System.Drawing.Point(15, 306);
            this.CWHeader.Name = "CWHeader";
            this.CWHeader.Size = new System.Drawing.Size(167, 22);
            this.CWHeader.TabIndex = 11;
            this.CWHeader.Text = "Currently Watching";
            // 
            // WatchedLocation
            // 
            this.WatchedLocation.AutoSize = true;
            this.WatchedLocation.Font = new System.Drawing.Font("Microsoft YaHei", 7F, System.Drawing.FontStyle.Bold);
            this.WatchedLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.WatchedLocation.Location = new System.Drawing.Point(15, 330);
            this.WatchedLocation.Name = "WatchedLocation";
            this.WatchedLocation.Size = new System.Drawing.Size(0, 19);
            this.WatchedLocation.TabIndex = 12;
            // 
            // CloseApp
            // 
            this.CloseApp.AutoSize = true;
            this.CloseApp.Font = new System.Drawing.Font("Microsoft YaHei", 8.6F, System.Drawing.FontStyle.Bold);
            this.CloseApp.ForeColor = System.Drawing.Color.White;
            this.CloseApp.Location = new System.Drawing.Point(14, 405);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(60, 25);
            this.CloseApp.TabIndex = 14;
            this.CloseApp.Text = "Close";
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // ResetCount
            // 
            this.ResetCount.AutoSize = true;
            this.ResetCount.Font = new System.Drawing.Font("Microsoft YaHei", 8.6F, System.Drawing.FontStyle.Bold);
            this.ResetCount.ForeColor = System.Drawing.Color.White;
            this.ResetCount.Location = new System.Drawing.Point(14, 366);
            this.ResetCount.Name = "ResetCount";
            this.ResetCount.Size = new System.Drawing.Size(130, 25);
            this.ResetCount.TabIndex = 15;
            this.ResetCount.Text = "Reset Counts";
            this.ResetCount.Click += new System.EventHandler(this.ResetCount_Click);
            // 
            // UIDash4
            // 
            this.UIDash4.AutoSize = true;
            this.UIDash4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.UIDash4.ForeColor = System.Drawing.Color.White;
            this.UIDash4.Location = new System.Drawing.Point(14, 271);
            this.UIDash4.Name = "UIDash4";
            this.UIDash4.Size = new System.Drawing.Size(20, 25);
            this.UIDash4.TabIndex = 19;
            this.UIDash4.Text = "-";
            // 
            // UIDash3
            // 
            this.UIDash3.AutoSize = true;
            this.UIDash3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.UIDash3.ForeColor = System.Drawing.Color.White;
            this.UIDash3.Location = new System.Drawing.Point(14, 209);
            this.UIDash3.Name = "UIDash3";
            this.UIDash3.Size = new System.Drawing.Size(20, 25);
            this.UIDash3.TabIndex = 18;
            this.UIDash3.Text = "-";
            // 
            // UIDash2
            // 
            this.UIDash2.AutoSize = true;
            this.UIDash2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.UIDash2.ForeColor = System.Drawing.Color.White;
            this.UIDash2.Location = new System.Drawing.Point(14, 147);
            this.UIDash2.Name = "UIDash2";
            this.UIDash2.Size = new System.Drawing.Size(20, 25);
            this.UIDash2.TabIndex = 17;
            this.UIDash2.Text = "-";
            // 
            // UIDash1
            // 
            this.UIDash1.AutoSize = true;
            this.UIDash1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.UIDash1.ForeColor = System.Drawing.Color.White;
            this.UIDash1.Location = new System.Drawing.Point(14, 86);
            this.UIDash1.Name = "UIDash1";
            this.UIDash1.Size = new System.Drawing.Size(20, 25);
            this.UIDash1.TabIndex = 16;
            this.UIDash1.Text = "-";
            // 
            // CopyStats
            // 
            this.CopyStats.AutoSize = true;
            this.CopyStats.Font = new System.Drawing.Font("Microsoft YaHei", 8.6F, System.Drawing.FontStyle.Bold);
            this.CopyStats.ForeColor = System.Drawing.Color.White;
            this.CopyStats.Location = new System.Drawing.Point(152, 366);
            this.CopyStats.Name = "CopyStats";
            this.CopyStats.Size = new System.Drawing.Size(58, 25);
            this.CopyStats.TabIndex = 20;
            this.CopyStats.Text = "Copy";
            this.CopyStats.Click += new System.EventHandler(this.CopyStats_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(231, 456);
            this.ControlBox = false;
            this.Controls.Add(this.CopyStats);
            this.Controls.Add(this.UIDash4);
            this.Controls.Add(this.UIDash3);
            this.Controls.Add(this.UIDash2);
            this.Controls.Add(this.UIDash1);
            this.Controls.Add(this.ResetCount);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.WatchedLocation);
            this.Controls.Add(this.CWHeader);
            this.Controls.Add(this.NumDelete);
            this.Controls.Add(this.NumRename);
            this.Controls.Add(this.NumCreated);
            this.Controls.Add(this.NumChanged);
            this.Controls.Add(this.DeletedHeader);
            this.Controls.Add(this.RenamedHeader);
            this.Controls.Add(this.CreatedHeader);
            this.Controls.Add(this.ChangedHeader);
            this.Controls.Add(this.BuildHeader);
            this.Controls.Add(this.UIHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "SysWatch";
            this.Load += new System.EventHandler(this.UI_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UI_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher SysWatchFile;
        private System.Windows.Forms.Label UIHeader;
        private System.Windows.Forms.Label BuildHeader;
        private System.Windows.Forms.Label ChangedHeader;
        private System.Windows.Forms.Label CreatedHeader;
        private System.Windows.Forms.Label DeletedHeader;
        private System.Windows.Forms.Label RenamedHeader;
        private System.Windows.Forms.Label NumDelete;
        private System.Windows.Forms.Label NumRename;
        private System.Windows.Forms.Label NumCreated;
        private System.Windows.Forms.Label NumChanged;
        private System.Windows.Forms.Label WatchedLocation;
        private System.Windows.Forms.Label CWHeader;
        private System.Windows.Forms.Label CloseApp;
        private System.Windows.Forms.Label ResetCount;
        private System.Windows.Forms.Label UIDash4;
        private System.Windows.Forms.Label UIDash3;
        private System.Windows.Forms.Label UIDash2;
        private System.Windows.Forms.Label UIDash1;
        private System.Windows.Forms.Label CopyStats;
    }
}

