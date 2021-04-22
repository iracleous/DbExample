using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyCore.Models
{
    public class Cart
    {
        public long CartId { get; set; }

        public DateTime Date { get; set; }


        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }


    }
}
