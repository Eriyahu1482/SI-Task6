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
using static SI_Task6.Core.Core;

namespace SI_Task6.View.MainPage.TaskPage
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void BTN1_Click(object sender, RoutedEventArgs e)
        {
            Brd1.Visibility = Visibility.Visible;
        }

        private void BTN2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN14_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
