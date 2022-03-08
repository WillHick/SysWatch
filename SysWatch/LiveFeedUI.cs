using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysWatch
{
    public partial class LiveFeedUI : Form
    {
        private int _eventcount = 0;

        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public LiveFeedUI()
        {
            InitializeComponent();
        }
        private void LiveFeedUI_Load(object sender, EventArgs e)
        {
            //Form Window
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(LiveFeedUI.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 840 - base.Size.Width, workingArea.Bottom - 6 - base.Size.Height);

            //System File Watch
            string path = "C:/";
            SysWatchLiveFeed.Path = path;
            SysWatchLiveFeed.EnableRaisingEvents = true;
            SysWatchLiveFeed.IncludeSubdirectories = true;

            //Feed Clearing
            FeedClear.Start();
        }
        private void SysWatchLiveFeed_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Changed - ",
                e.Name,
                e.FullPath                
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            this.Text = "SysWatch - Live Feed : Events Logged > " + this._eventcount.ToString();
        }
        private void SysWatchLiveFeed_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Created - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            this.Text = "SysWatch - Live Feed : Events Logged > " + this._eventcount.ToString();
        }
        private void SysWatchLiveFeed_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Deleted - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            this.Text = "SysWatch - Live Feed : Events Logged > " + this._eventcount.ToString();
        }
        private void SysWatchLiveFeed_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Renamed - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            this.Text = "SysWatch - Live Feed : Events Logged > " + this._eventcount.ToString();
        }
        private void HideFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedClear.Stop();
        }
        private void FeedClear_Tick(object sender, EventArgs e)
        {
            Output.ResetText();
            Output.Clear();
        }
    }
}
