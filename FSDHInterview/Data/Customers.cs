using System;

namespace FSDHInterview.Data
{
    /// <summary>
    /// Model for Customers table in the database.
    /// </summary>
    public class Customers
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public int CustomerCategory { get; set; }
        public decimal InterestRate { get; set; }
        public decimal OpeningBalance { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
