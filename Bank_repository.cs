using System;
using System.Collections.Generic;
using System.Text;


namespace task1_SQLtehtävä.Repositories
{
    class Bank_repo
    {
        private static BankdbContext _context = new BankdbContext();

        public static void Create(Bank bank)
        {
            _context.Bank.Add(bank);
            _context.SaveChanges();
        }
        public static List<Bank> Get()
        {
            List<Bank> banks = _context.Bank.ToListAsync().Result;
        }
    }
}

// Public void Add(transaction);

   // using var context = new BankdbContext())
   // {
     //   try
      //  {
            // lisätään tapahtumatauluun rici
          //  context.Add(transaction);
            // lasketaan tilille saldoa
           // var account = GetAccountByIban(Transactoin.Iban);
            // lasketaan tilille uusi saldoa
          //  account.Balance += transaction.Iban);

            // Update Account table
         //   context.Account.Update(account);
            // tallennetaan muutokset tietokantaan
       //     context.SaveChanges();



    