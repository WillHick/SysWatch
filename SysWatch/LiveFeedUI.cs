using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysWatch
{
    public partial class LiveFeedUI : Form
    {
        private int _eventcount = 0;

        public LiveFeedUI()
        {
            InitializeComponent();
        }
        private void LiveFeedUI_Load(object sender, EventArgs e)
        {
            //Set Window
            this.CenterToScreen();

            //System File Watch
            string path = "C:/";
            SysWatchLiveFeed.Path = path;
            SysWatchLiveFeed.EnableRaisingEvents = true;
            SysWatchLiveFeed.IncludeSubdirectories = true;
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
        //Tool Strip Functions
        private void TSClear_Click(object sender, EventArgs e)
        {
            Output.Clear();
        }
    }
}
