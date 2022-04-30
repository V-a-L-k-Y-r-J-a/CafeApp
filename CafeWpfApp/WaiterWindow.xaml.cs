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

namespace CafeWpfApp
{
    /// <summary>
    /// Логика взаимодействия для WaiterWindow.xaml
    /// </summary>
    public partial class WaiterWindow : Window
    {
        public WaiterWindow()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            OrdersDGrid.ItemsSource = Helper.db.Orders.Where(q => q.StatusOrder <= 2).Include(w => w.StatusOrder).Include(e => e.User).Tolist();

        }


        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditOrderBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteOrderBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
