using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using task1_SQLtehtävä.model;

namespace task1_SQLtehtävä.repositories
{
    class Transaction_repository
    {
        private static BankdbContext _context = new BankdbContext();

        public static void Create(Transaction transaction)
        {
            _context.Bank.Add(transaction);
            _context.SaveChanges();
        }
        public static List<Transaction>Get()
        {
            List<Transaction> transactions = _context.Transaction.ToListAsync().Result;
        }
}
