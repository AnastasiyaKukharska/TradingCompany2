using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class BasketDetailsModel
    {
        public int BasketID { get; set; }
        public string  Author { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        [DisplayName("Status")]
        public int StatusID { get; set; }

        [DisplayName("Added On")]
        public DateTime Date { get; set; }

    }
}