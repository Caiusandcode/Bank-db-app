using System;
using System.Collections.Generic;
using System.Text;

namespace task1_SQLtehtävä.repositories
{
    class Customer_repository
    {
        private static BankdbContext _context = new BankdbContext();

        public static void Create(Customer customer)
        {
            _context.Bank.Add(customer);
            _context.SaveChanges();
        }
        public static List<Customer> Get()
        {
            List<Customer> customers = _context.Customer.ToListAsync().Result;
        }
    }
