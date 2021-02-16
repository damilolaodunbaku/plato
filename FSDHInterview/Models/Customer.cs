using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHInterview.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public int CustomerCategory { get; set; }
        public decimal InterestRate { get; set; }
        public decimal OpeningBalance { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<decimal> CarLoans { get; set; }
        public List<decimal> MortgageLoans { get; set; }
        public List<decimal> PersonalLoans { get; set; }
    }
}
