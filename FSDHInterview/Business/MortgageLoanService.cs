using FSDHInterview.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace FSDHInterview.Business
{
    public class MortgageLoanService
    {
        private decimal InterestRate;
        public MortgageLoanService(IConfiguration configuration)
        {
            InterestRate = decimal.Parse(configuration["InterestRates:MortgageLoan"]);
        }

        /// <summary>
        /// Get the number of mortgage loans belonging to a customer
        /// </summary>
        /// <param name="customer"></param>
        public int GetAllLoanCount(int customerId)
        {
            Customer customer = GetCustomerFromDatabase(customerId);

            if (customer == null)
            {
                throw new ApplicationException("Customer doesn't exist.");
            }

            return 1;
        }

        /// <summary>
        /// Issue the customer a mortgage loan
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public void IssueLoan(int customerId)
        {
            Customer customer = GetCustomerFromDatabase(customerId);

            if (customer == null)
            {
                throw new ApplicationException("Customer doesn't exist.");
            }

            if (customer.MortgageLoans == null)
            {
                customer.MortgageLoans = new List<decimal>();
            }
            else if (customer.MortgageLoans.Count > 2)
            {
                throw new ApplicationException("Customer cannot have more than 2 mortgage loans");
            }

            var loanAmount = CalculateLoanAmount(customer, LoanType.MortgageLoan);

            customer.MortgageLoans.Add(loanAmount);
        }

        private Customer GetCustomerFromDatabase(int customerId)
        {
            if (customerId % 2 == 0)
            {
                return new Customer
                {
                    Age = 21,
                    CustomerCategory = 3,
                    FirstName = "Test",
                    LastName = "Customer",
                    MiddleName = "FSDH",
                    InterestRate = 2.5M,
                    OpeningBalance = 1000M,
                    RegistrationDate = new DateTime(2015, 05, 04)
                };
            }

            return null;
        }

        private decimal CalculateLoanAmount(Customer customer, LoanType loanType)
        {
            decimal loanAmount = 0m;

            switch (loanType)
            {
                case LoanType.CarLoan:
                    loanAmount = 50000m;
                    break;
                case LoanType.MortgageLoan:
                    loanAmount = 150000m;
                    break;
                case LoanType.PersonalLoan:
                    loanAmount = 20000m;
                    break;
                default:
                    break;
            }

            if (customer.Age > 30)
            {
                loanAmount += 50000m;
            }
            else
            {
                loanAmount += 30000m;
            }

            return loanAmount -= loanAmount * InterestRate;
        }
    }
}
