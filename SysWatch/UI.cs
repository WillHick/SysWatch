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
    public partial class UI : Form
    {
        SysWatch.DoubleClickMenu DCMUI = new SysWatch.DoubleClickMenu();

        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);     

        public UI()
        {
            InitializeComponent();
        }
        private void UI_Load(object sender, EventArgs e)
        {
            //Form Window
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(UI.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 8 - base.Size.Width, workingArea.Bottom - 6 - base.Size.Height);

            //System File Watch
            string path = "C:/";
            SysWatchFile.Path = path;
            SysWatchFile.EnableRaisingEvents = true;
            SysWatchFile.IncludeSubdirectories = true;
            WatchedLocation.Text = SysWatchFile.Path.ToString();

            //Other
            this.ShowIcon = false;
            this.TopMost = false;
        }

        //Ints
        private int _change = 0;
        private int _create = 0;
        private int _delete = 0;
        private int _rename = 0;

        //SysWatch Update
        private void SysWatch_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            this._change++;
            this.NumChanged.Text = this._change.ToString();
        }
        private void SysWatch_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            this._create++;
            this.NumCreated.Text = this._create.ToString();
        }
        private void SysWatch_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            this._delete++;
            this.NumDelete.Text = this._delete.ToString();
        }
        private void SysWatch_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            this._rename++;
            this.NumRename.Text = this._rename.ToString();
        }
        //Application
        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ResetCount_Click(object sender, EventArgs e)
        {
            this._rename = 0;
            this._change = 0;
            this._create = 0;
            this._delete = 0;
        }
        private void UI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DCMUI.Show();
        }
        private void CopyStats_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Copied At  : " + DateTime.Now.ToShortTimeString() + Environment.NewLine + "Changed Files : " + NumChanged.Text.ToString() + Environment.NewLine + "Created Files : " + NumCreated.Text.ToString() + Environment.NewLine + "Renamed Files : " + NumRename.Text.ToString() + Environment.NewLine + "Deleted Files : " + NumDelete.Text.ToString());
        }
    }
}