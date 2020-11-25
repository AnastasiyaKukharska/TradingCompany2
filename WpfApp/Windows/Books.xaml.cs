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
    /// Interaction logic for Books.xaml
    /// </summary>

    public partial class Books : Window
    {
       BooksListViewModel _bookListViewModel;
        CollectionViewSource _bookCollection;
        public List<BooksDTO> BookList;

        public Books(BooksListViewModel vm)
        {
            BookList = new List<BooksDTO>();
            _bookCollection = (CollectionViewSource)(Resources["BookCollection"]);
            _bookListViewModel = vm;
            DataContext = vm;
            InitializeComponent();
        }


        private void FindButton(object sender, RoutedEventArgs e)
        {
           BooksDTO book = (BooksDTO)dataGrid.SelectedItem;
               _bookListViewModel.Update(CategoryBox.Text, TitleBox.Text);
            dataGrid.Items.Refresh();
        }
        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
