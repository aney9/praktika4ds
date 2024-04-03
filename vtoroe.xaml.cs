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
    /// Логика взаимодействия для vtoroe.xaml
    /// </summary>
    public partial class vtoroe : Window
    {
        MestoTableAdapter mesto = new MestoTableAdapter();
        public vtoroe()
        {
            InitializeComponent();
            vybor.ItemsSource = mesto.GetData();
            vybor.DisplayMemberPath = "Mesto";
        }

        private void pokaz(object sender, RoutedEventArgs e)
        {
            dg1.ItemsSource = mesto.GetData();
        }

        private void vyhod(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void poiskk(object sender, RoutedEventArgs e)
        {
            dg1.ItemsSource = mesto.pois(SearchTxt.Text);
        }

        private void vybor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(vybor.SelectedItem != null)
            {
                var id = (vybor.SelectedItem as DataRowView).Row[2].ToString();
                dg1.ItemsSource = mesto.filtr(id);
            }
        }
    }
}
