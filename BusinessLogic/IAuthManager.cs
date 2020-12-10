using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IAuthManager
    {
        bool Login(string username, string password);
        int UID(string username);
        int CD(string category);
        int BD(string title);
        UserDTO GetUserByLogin(string username);

    }
}
