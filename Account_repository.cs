using System;
using System.Collections.Generic;
using System.Text;

namespace task1_SQLtehtävä.repositories
{
    class Account_repository
    {
        private static BankdbContext _context = new BankdbContext();

        public static void Create(Account account)
        {
            _context.Bank.Add(account);
            _context.SaveChanges();
        }
        public static List<Account> Get()
        {
            List<Account> accounts = _context.Account.ToListAsync().Result;
        }
    }
    