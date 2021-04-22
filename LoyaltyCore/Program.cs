using LoyaltyCore.Models;
using LoyaltyCore.Persistence;
using System;

namespace LoyaltyCore
{
    static class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new() { Email = "george@gmail.com", Password = "xxx" };

            Console.WriteLine($"{customer.Email} {customer.Password} {customer.CustomerId}");

            LoyaltyDb loyaltyDb = new();
            loyaltyDb.Customers.Add(customer);
            loyaltyDb.SaveChanges();
            Console.WriteLine($"{customer.Email} {customer.Password} {customer.CustomerId}");
        }
    }
}
