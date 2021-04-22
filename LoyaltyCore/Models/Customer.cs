using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyCore.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Cart> Carts { get; set; }

        public Customer()
        {
            Carts = new List<Cart>();
        }
    }
}
