using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.App.Security
{
    public class CustomSerializeModel
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public List<string> Roles { get; set; }
    }
}