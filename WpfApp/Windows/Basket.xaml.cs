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
using DTO;

namespace WpfApp.Windows
{
    /// <summary>
    /// Interaction logic for Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        BasketViewModel _basketViewModel;
        CollectionViewSource _basketCollection;
        public BasketDTO Baskett;

        public Basket(BasketViewModel vm)
        {
            Baskett = new BasketDTO();
            _basketCollection = (CollectionViewSource)(Resources["BasketCollection"]);
            _basketViewModel = vm;
            DataContext = vm;
            InitializeComponent();

        }
        private void AddButton(object sender, RoutedEventArgs e)
        {

            BasketDTO basket = (BasketDTO)dataGrid2.SelectedItem;
            _basketViewModel.ADD(TitleBox2.Text);
            _basketViewModel.Update();
            dataGrid2.Items.Refresh();
        }
        private void ExitButton2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void OrderButton(object sender, RoutedEventArgs e)
        {
            _basketViewModel.Order();
        }
        private void BuyButton(object sender, RoutedEventArgs e)
        {
            _basketViewModel.Buy();
        }

    }
}
