using LoyaltyCore.Models;
using LoyaltyCore.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyCore.Services
{
    public interface ILoyaltyService
    {
        public Customer RegisterCustomer(CustomerOption customerOption);

        public Customer GetCustomer(CustomerOption customerOption);

        public List<Customer> GetCustomers(CustomerOption customerOption);

        public Customer UpdateCustomer(long CustomerId, CustomerOption customerOption);

        public bool DeleteCustomer(long CustomerId);


    }
}
