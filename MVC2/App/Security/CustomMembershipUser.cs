using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVC2.App.Security
{
    public class CustomMembershipUser : MembershipUser
    {
        public int UserId { get; set; }
        public ICollection<PrivilegeDTO> Roles { get; set; }

        public CustomMembershipUser(UserDTO user)
            : base("CustomMembership",
                  user.Login,
                  user.UserID,
                  string.Empty,
                  string.Empty,
                  true, false,
                  DateTime.Now,
                  DateTime.Now,
                  DateTime.Now,
                  DateTime.Now)
        {
            UserId = user.UserID;
            Roles = user.Privileges;
        }
    }
}