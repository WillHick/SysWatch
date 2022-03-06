﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysWatch
{
    public partial class DoubleClickMenu : Form
    {
        public DoubleClickMenu()
        {
            InitializeComponent();
        }
        private void DoubleClickMenu_Load(object sender, EventArgs e)
        {
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
            MessageBox.Show("Thank You <3");
        }
    }
}
