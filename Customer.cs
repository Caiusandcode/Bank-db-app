using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models
{
    public partial class Customer
    {
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public long Id { get; set; }
        [Required]
        [Column("First name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column("Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        public long BankId { get; set; }
    }
}
