﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysWatch
{
    public partial class MoreMenu : Form
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public MoreMenu()
        {
            InitializeComponent();
        }
        private void DoubleClickMenu_Load(object sender, EventArgs e)
        {
            //Form Position
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 248 - base.Size.Width, workingArea.Bottom - 6 - base.Size.Height);

            //Form Window
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(MoreMenu.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));

            //Text Set
            ApText.Text = "App Path : " + Application.ExecutablePath.ToString();
            SpText.Text = "Start Path : " + Application.StartupPath.ToString();
            AvText.Text = "App Version : " + Application.ProductVersion.ToString();
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/WillHick/SysWatch");
        }
        private void Other_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/WillHick/SysWatch-LiveFeed");
        }
    }
}