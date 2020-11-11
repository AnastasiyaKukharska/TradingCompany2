
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Customer : ICustomer
    {
        private readonly IBasketDal _basketDal;
        private readonly IBooksDal _booksDal;
        private readonly IUserDal _userDal;
        public Customer(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public bool Login(string username, string password)
        {
            return _userDal.Login(username, password);
        }

        public  Customer(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }
        public Customer(IBooksDal booksDal)
        {
            _booksDal = booksDal;
        }
        public BasketDTO AddBasket(BasketDTO basket)
        {
            return _basketDal.CreateBasket(basket);
        }
        public void GetBasket(int id)
        {
            _basketDal.GetBasketById(id);
        }
        public  void UpdateStatus(int id, int Sid)
        {
            _basketDal.UpdateBasket(id,Sid);
        }
        public List<BooksDTO> FindBook(string text, string c)
        {
           return  _booksDal.Find(text,c);
        }
        public void AddBook(string t, int id)
        {
            _basketDal.AddBook(t,  id);
        }
    }
}