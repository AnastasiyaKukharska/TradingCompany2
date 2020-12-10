using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
        public interface ICustomer
        {
            BasketDTO AddBasket(BasketDTO basket);
            void GetBasket(int id);
            void UpdateStatus(int id, int Sid);
            List<BooksDTO> FindBook(string text, string id);
            bool Login(string username, string password);
            void AddBook(string t, int id);
            BasketDTO GetBasket2(int id);
        }
}
