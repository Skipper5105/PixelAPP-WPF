using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PixelWPF.Views
{
    /// <summary>
    /// Interaction logic for Support.xaml
    /// </summary>
    public partial class Support : UserControl
    {
        public Support()
        {
            InitializeComponent();
        }


        private void GithubBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Skipper5105/PixelApp/issues");
        }

        private void GithubBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Skipper5105/PixelApp/issues",
                UseShellExecute = true
            });
        }
    }
}
