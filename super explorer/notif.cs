using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_explorer
{
    public partial class notif : Form
    {
        public notif(String mesg, int category = globals.CAT_NORMAL)
        {
            InitializeComponent();
            message.Text = mesg;
            switch (category)
            {
                case globals.CAT_SUCCESS:
                    this.BackColor = System.Drawing.Color.MediumSeaGreen;
                    break;
                case globals.CAT_WARNING:
                    this.BackColor = System.Drawing.Color.Orange;
                    break;
                case globals.CAT_NORMAL:
                default:
                    this.BackColor = System.Drawing.Color.SkyBlue;
                    break;
            }
            message.BackColor = this.BackColor;
        }

        private void notif_Load(object sender, EventArgs e)
        {
            Screen sobj = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > sobj.WorkingArea.Right)
                    sobj = screen;
            }

            this.Left = sobj.WorkingArea.Right - this.Width;
            this.Top = sobj.WorkingArea.Top;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class globals
    {
        public const int CAT_NORMAL = 0;
        public const int CAT_SUCCESS = 1;
        public const int CAT_WARNING = 2;
    };
}
