using BusinessLogic;
using DTO;
using WpfApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    static class Global
    {
        public static int ID;
    }
    public class BasketViewModel : INotifyPropertyChanged
    {
        private ICustomer _customer;

        private BasketDTO _basket;
        public BasketDTO Basket
        {
            get { return _basket; }
            set
            {
                _basket = value;
                OnPropertyChanged(nameof(Basket));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


        private IAuthManager _manager;


        public BasketViewModel(ICustomer customer, string cID, string bID)
        {
            _customer = customer;
            Update();
        }

        public void Update()
        {
            var basket=_customer.GetBasket(Global.ID);
            Basket = new ObservableCollection<BasketDTO>(basket);
        }
        public void Order()
        {
            _customer.UpdateStatus(Global.ID, 2);
        }
        public void Buy()
        {
            _customer.UpdateStatus(Global.ID, 1);
        }
        public void ADD(string t)
        {
            _customer.AddBook(t, Global.ID);
        }
    }
}
