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
    public partial class PopupAlert : Form
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public PopupAlert()
        {
            InitializeComponent();
        }
        private void PopupAlert_Load(object sender, EventArgs e)
        {
            //Form Window
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(PopupAlert.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 8 - base.Size.Width, workingArea.Bottom - 469 - base.Size.Height);
        }
        private void Heart_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
