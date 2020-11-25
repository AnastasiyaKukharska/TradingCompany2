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
using WpfApp.ViewModels;

namespace WpfApp.Windows
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        BooksListViewModel vm;
        BasketViewModel vb;
        public Menu()
        {
            InitializeComponent();
        }
        private void BooksButton(object sender, RoutedEventArgs e)
        {
            this.Close();
            Books book = new Books(vm);
            book.Show();
        }
        private void BasketButton(object sender, RoutedEventArgs e)
        {
            this.Close();
            Basket basket = new Basket(vb);
            basket.Show();
        }
    }
}
