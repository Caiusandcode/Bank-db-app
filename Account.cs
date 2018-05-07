using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models
{
    public partial class Account
    {
        public Account(string iban, string name, long bankId, long customerId, decimal balance, Bank bank)
        {
            Iban = iban;
            Name = name;
            BankId = bankId;
            CustomerId = customerId;
            Balance = balance;
            Bank = bank;
        }

        [Key]
        [Column("IBAN", TypeName = "nchar(20)")]
        public string Iban { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public long BankId { get; set; }
        public long CustomerId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Balance { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("Account")]
        public Bank Bank { get; set; }
    }
}
