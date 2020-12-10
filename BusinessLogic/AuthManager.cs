
using DAL.Interfaces;

namespace BusinessLogic
{
    public class AuthManager : IAuthManager
    {
        private readonly IUserDal _userDal;
        private readonly IBasketDal _basketDal;
        private readonly ICategoriesDal _categoryDal;
        private readonly IBooksDal _bookDal;
        public AuthManager(IUserDal userDal, IBasketDal basketDal, ICategoriesDal categoryDal, IBooksDal bookDal)
        {
            _userDal = userDal;
            _bookDal = bookDal;
            _basketDal = basketDal;
            _categoryDal = categoryDal;
        }

        public bool Login(string username, string password)
        {
            return _userDal.Login(username, password);
        }
       public  int UID(string username)
        {
            return _basketDal.UD(username);
        }
        public int CD(string category)
        {
            _categoryDal.CD(category);
        }
        public int BD(string titl)
        {
            _bookDal.BD(titl);
        }
        public UserDTO GetUserByLogin(string username)
        {
            return _userDal.GetUserByLogin(username);
        }

    }
}
