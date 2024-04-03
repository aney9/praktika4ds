using prakt4ds.praktikaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace prakt4ds
{
    /// <summary>
    /// Логика взаимодействия для tri.xaml
    /// </summary>
    public partial class tri : Window
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();
        public tri()
        {
            InitializeComponent();
            vybor.ItemsSource = orders.GetData();
            vybor.DisplayMemberPath = "DataPokupki";
        }

        private void vybor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (vybor.SelectedItem != null)
            {
                var id = (vybor.SelectedItem as DataRowView).Row[1].ToString();
                dg1.ItemsSource = orders.filtr(id);
            }
        }

        private void vyhod(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void pokaz(object sender, RoutedEventArgs e)
        {
            dg1.ItemsSource = orders.GetData();
        }

        private void poiskk(object sender, RoutedEventArgs e)
        {
                dg1.ItemsSource = orders.pois(SearchTxt.Text);
        }

        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
