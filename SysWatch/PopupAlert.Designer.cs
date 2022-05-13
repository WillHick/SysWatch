
namespace SysWatch
{
    partial class PopupAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupAlert));
            this.Heart = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Heart
            // 
            this.Heart.AutoSize = true;
            this.Heart.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.Heart.ForeColor = System.Drawing.Color.Pink;
            this.Heart.Location = new System.Drawing.Point(87, 26);
            this.Heart.Name = "Heart";
            this.Heart.Size = new System.Drawing.Size(55, 37);
            this.Heart.TabIndex = 17;
            this.Heart.Text = "<3";
            this.Heart.Click += new System.EventHandler(this.Heart_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft YaHei", 8.6F, System.Drawing.FontStyle.Bold);
            this.Date.ForeColor = System.Drawing.Color.Pink;
            this.Date.Location = new System.Drawing.Point(87, 69);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(56, 25);
            this.Date.TabIndex = 16;
            this.Date.Text = "1401";
            // 
            // PopupAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(231, 121);
            this.ControlBox = false;
            this.Controls.Add(this.Heart);
            this.Controls.Add(this.Date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupAlert";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SysWatch - Alert";
            this.Load += new System.EventHandler(this.PopupAlert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heart;
        private System.Windows.Forms.Label Date;
    }
}