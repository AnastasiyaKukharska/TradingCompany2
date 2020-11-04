using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.Interfaces
{
    public interface IUserDal
    {
        UserDTO CreateUser( string username, string password);
        bool Login(string username, string password);
    }
}
