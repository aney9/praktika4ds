using prakt4ds.praktikaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для pervoe.xaml
    /// </summary>
    public partial class pervoe : Window
    {
        ClientsTableAdapter clients = new ClientsTableAdapter();
        public pervoe()
        {
            InitializeComponent();
            vybor.ItemsSource = clients.GetData();
            vybor.DisplayMemberPath = "Email";
        }
        private void poiskk(object sender, RoutedEventArgs e)
        {
            dg1.ItemsSource = clients.pois(SearchTxt.Text);
        }

        private void pokaz(object sender, RoutedEventArgs e)
        {
            dg1.ItemsSource = clients.GetData();
        }

        private void vyhod(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        private void vybor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                var id = (vybor.SelectedItem as DataRowView).Row[6].ToString();
                dg1.ItemsSource = clients.filtr(id);
        }
    }
}
