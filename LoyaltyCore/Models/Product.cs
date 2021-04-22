using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyCore.Models
{
    public class Product
    {
        public long ProductId { get; set; }

        public string Name {get; set;  }
        public decimal Price {get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection<Cart> Carts  { get; set; }


        public Product()
        {
            Carts = new List<Cart>();
        }
    }
}
