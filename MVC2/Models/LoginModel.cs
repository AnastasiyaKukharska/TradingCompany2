using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class LoginModel
    {
        [DisplayName("Login")]
        [Required]
        [MinLength(1)]
        public string UserName { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }
    }
}