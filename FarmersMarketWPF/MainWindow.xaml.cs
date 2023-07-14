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

namespace FarmersMarket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, RoutedEventArgs e)
        {
            Admin adminView = new Admin();
            adminView.Show();
        }

        private void btn_Customer_Click(object sender, RoutedEventArgs e)
        {
            Sales userView = new Sales();
            userView.Show();
        }
    }
}
