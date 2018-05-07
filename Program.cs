using System;
using System.Linq;
using BankApp.Views;
using BankApp.Models;
using BankApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Program
    {
        static BankView bankView = new BankView();

        static void Main(string[] args)
        {
            Console.WriteLine("Bank App versio 1.0");
            //CreateBank();
            //ReadBanks();
           // GetBankById();
           // UpdateBank();
            bankView.GetBankByName();
            bankView.DeleteBank();
            Console.WriteLine("Enter Lopettaa");
            Console.ReadLine();

        }


        static void CreateCustomer()
        {
            
            Customer customer = new Customer( "Masa", "Myyrä")
            {
                         
            };

          
        }
       
    }
}
