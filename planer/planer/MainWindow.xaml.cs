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

namespace planer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            orders.Items.Add
                (
                new Order
                {
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem>{
                        new OrderItem {Amount = 1, Width = 10, Length = 20},
                        new OrderItem {Amount = 2, Width = 10, Length = 20},
                        new OrderItem {Amount = 3, Width = 10, Length = 20},
                    }
                }
                );
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
