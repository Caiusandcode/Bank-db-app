using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models
{
    public partial class Bank
    {
        public Bank(string name, string bic, ICollection<Account> account)
        {
            Name = name;
            Bic = bic;
            Account = account;
        }

        public long Id { get; set; }
        [Column("name", TypeName = "nchar(10)")]
        public string Name { get; set; }
        [Column("BIC", TypeName = "nchar(10)")]
        public string Bic { get; set; }

        [InverseProperty("Bank")]
        public ICollection<Account> Account { get; set; }
    }
}
