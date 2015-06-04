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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace SE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public log l = new log();
        public string[] files;
        public string root = @"C:\testcase\";
        public MainWindow()
        {
            InitializeComponent();
            
            l.Show();
        }

        public void _log(string m) {
            __log.Text += m + Environment.NewLine;
            l.Put(m);
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            // perfrom all initialisations here
            files = Directory.GetFiles(root);
            __log.Text = "Logs" + Environment.NewLine;

            Grid grid_t = new Grid();
            grid_t.Margin = new Thickness(0);
            grid_t.Height = 350;
            grid_t.Width = 525;

            int i = 1;
            foreach (string f in files) {
                Image j = new Image();
                ImageSource MoleImage = new BitmapImage(new Uri(f));
                j.Source = MoleImage;
                j.Width = 100;
                j.Height = 100;
                j.Margin = new Thickness(200 * ((i - 1) % 3), 0, 0, -1 * (int)((i - 1) / 3) * 200);
                grid_t.Children.Add(j);

                ++i;
            }

            workspace.Children.Add(grid_t);
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(@"C:\testcase\1.jpg"));
            preview.Background = myBrush;
            preview.Effect = new System.Windows.Media.Effects.BlurEffect();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button clicked", "informative box", MessageBoxButton.YesNoCancel, MessageBoxImage.Information);
        }

        private void SE_FORM_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            l.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            slider_opacity.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            slider_opacity.Visibility = Visibility.Hidden;
            this.Opacity = 1;
        }

        private void slider_opacity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.Opacity = slider_opacity.Value / 100;
        }

        private bool search_state = false;
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            panel_search.Visibility = Visibility.Visible;
            search_state = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            panel_search.Visibility = Visibility.Hidden;
            search_state = false;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            image_button_search.Source = new BitmapImage(new Uri(@"C:\testcase\search_hover.png"));
        }

        private void image_button_search_MouseLeave(object sender, MouseEventArgs e)
        {
            image_button_search.Source = new BitmapImage(new Uri(@"C:\testcase\search.png"));
        }
    }
}
