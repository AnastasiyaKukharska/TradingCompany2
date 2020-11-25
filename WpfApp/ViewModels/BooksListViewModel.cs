using BusinessLogic;
using DTO;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace WpfApp.ViewModels
{
    public class BooksListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        private ICustomer _customer;
       
        private ObservableCollection<BooksDTO> _bookList;
        public ObservableCollection<BooksDTO> BookList
        {
            get { return _bookList; }
            set
            {
                _bookList = value;
                OnPropertyChanged(nameof(BookList));
            }
        }

        public BooksListViewModel(ICustomer customer,string cID,string bID)
        {
            _customer = customer;
            Update(cID,bID);
        }

        public void Update(string c, string t)
        {
            var books = _customer.FindBook(c,t);
            BookList = new ObservableCollection<BooksDTO>(books);
        }
      
    }
}
