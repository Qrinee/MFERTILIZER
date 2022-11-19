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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool added = false;
        public MainWindow()
        {
            InitializeComponent();

            addedCompost();
        }


        
        public void addedCompost()
        {
            form1.Visibility = Visibility.Hidden;  
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            oneItem.Visibility = Visibility.Hidden;
            form1.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            form1.Visibility = Visibility.Hidden;
            forum.Visibility = Visibility.Hidden;
            oneItem.Visibility = Visibility.Visible;
            buttonAdd.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forum.Visibility = Visibility.Visible;
            oneItem.Visibility = Visibility.Hidden;
            buttonAdd.Visibility = Visibility.Hidden;
        }

     
    }
}
