using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.CodeFirst
{
   public class Order
    {
       [Key]
       public int OrderId { get; set; }
       public DateTime OrderDate { get; set; }
       public string ShipToAddress { get; set; }
       public int CustomerId { get; set; }

       // navigation properties
       public virtual Customer Customer { get; set; }
    }
}
