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

namespace prakt4ds
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list = new List<string> { "Clients", "Mesto", "Orders" };
        public MainWindow()
        {
            InitializeComponent();
            vybor1.ItemsSource = list;
        }

        private void vybor1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (vybor1.SelectedItem == list[0])
            {
                pervoe Pervoe = new pervoe();
                Pervoe.Show();
                this.Close();
            }
            if (vybor1.SelectedItem == list[1])
            {
                vtoroe Vtoroe = new vtoroe();
                Vtoroe.Show();
                this.Close();
            }
            if (vybor1.SelectedItem == list[2])
            {
                tri Tri = new tri();
                Tri.Show();
                this.Close();
            }
        }
    }
}
