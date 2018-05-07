using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Repositories;
using BankApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace BankApp.Views
{
    class Account_view
    {
        AccountRepository accountRepository = new AccountRepository();

        public void ReadBalance()
        {
            List<Account> accounts = accountRepository.GetAccounts();
            foreach (var b in accounts)
            {
                Console.WriteLine($"{b.Name}\t{b.Balance}\t{b.Iban}");
            }


        }
    }
}
