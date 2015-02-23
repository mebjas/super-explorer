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
    public partial class main : Form
    {
        public String[] quicklinks_data = {"Images", "Videos", "Movies", "Music", "Desktop", "Documents", "Mails"};
        public main()
        {
            InitializeComponent();
            log("system loaded");
        }

        private void main_Load(object sender, EventArgs e)
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();
            log("loading all logical drives");
            int i = 0;
            foreach (string str in drives)
            {
                tree.Nodes.Add(str);
                workspace.Items.Add(str);
                workspace.Items[i++].ImageIndex = 0;
                log(str);
            }

            foreach (string s in quicklinks_data)
            {
                quicklinks.Items.Add(s);
                log("added " +s +" to the quick links");
            }
        }

        public void log(String m) {
            console.Text += m + Environment.NewLine;
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
        }
    }
}
