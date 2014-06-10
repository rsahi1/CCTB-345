using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(75)]
        public string description { get; set; }

        [Required(ErrorMessage="Product Name is Required"), StringLength(25, MinimumLength=5, ErrorMessage="Product names are between 5 and 25 characters in length")]
        public string name { get; set; }


    }
}
