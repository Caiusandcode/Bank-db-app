using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
        }

        public Transaction(string iban, decimal amount, DateTime timestamp)
        {
            Iban = iban;
            Amount = amount;
            Timestamp = timestamp;
        }

        public long Id { get; set; }
        [Required]
        [Column("IBAN", TypeName = "nchar(20)")]
        public string Iban { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime Timestamp { get; set; }
    }
}
