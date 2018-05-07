using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BankApp.Models;
using BankApp.Repositories;

namespace BankApp.Views
{
    class BankView
    {
        private readonly BankRepository bankRepository = new BankRepository();
        // public void CreateBank()
        // {
        //Bank newBank = new Bank("S-pankki2", "SBank");

        //bankRepository.Create(newBank);
        // }

        public void ReadBanks()
        {
            List<Bank> banks = bankRepository.GetBanks();
            foreach (var b in banks)
            {
                Console.WriteLine($"{b.Id}\t{b.Name}\t{b.Bic}");
            }
        }

        public void GetBankById()
        {
            var bank = bankRepository.GetBankById(2);
            Console.WriteLine($"{bank.Id}\t{bank.Name}\t{bank.Bic}");

        }

        public void GetBankByName()
        {
            var bank = bankRepository.GetBankByName("SX-Bank");
            Console.WriteLine($"{bank.Id}\t{bank.Name}\t{bank.Bic}");

        }

        public void UpdateBank()
        {
            var bank = bankRepository.GetBankById(3);
            Console.Write($"Nykyinen nimi {bank.Name} -> Muuta nimi: ");
            bank.Name = Console.ReadLine();
            bankRepository.UpdateBank(bank);
        }

        public void DeleteBank()
        {
            ReadBanks();
            Console.Write("\nPoista pankki, syötä <ID>: ");
            long id = long.Parse(Console.ReadLine());
            bankRepository.DeleteBank(id);
            ReadBanks();
        }

        public void ShowAllData(Bank bankCustomer) {

            {
                Console.WriteLine(bC.ToString());
                foreach (var c in bC.Customer)
                {
                    Console.WriteLine(c.ToString);
                    foreach (var cAccount in c.Account)
                    {
                        Console.WriteLine($"\t{cAccount ToString()}");
                        foreach (var trn in cAccount.Transaction)
                        {
                            Console.WriteLine($"\t{trn.ToString()}");
                        }
                    }
                }
            }

        }
    }

}
