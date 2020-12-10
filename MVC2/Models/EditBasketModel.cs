using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Models
{
    public class EditBasketModel
    {
        public EditBasketModel() { }

        public int BasketID { get; set; }

        [Required]
        [MinLength(1)]
        public string Author { get; set; }

        [Required]
        [MinLength(1)]
        public string Title { get; set; }

        [Required]
        [MinLength(1)]
        public int Amount { get; set; }


        [DisplayName("Status")]
        public int StatusID { get; set; }

        public List<SelectListItem> Books { get; set; }
        public DateTime RowInsertTime { get; set; }

    }
}