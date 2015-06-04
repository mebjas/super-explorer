using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SE
{
    /// <summary>
    /// Interaction logic for log.xaml
    /// </summary>
    public partial class log : Window
    {
        public log()
        {
            InitializeComponent();
            rtb.Document.Blocks.Clear();
            rtb.Document.Blocks.Add(new Paragraph(new Run("Logs:" + Environment.NewLine)));
        }

        public void Put(string m) 
        {
            rtb.AppendText(m + Environment.NewLine);
            rtb.ScrollToEnd();
        } 
    }
}
