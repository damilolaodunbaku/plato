using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHInterview.Repository
{
    public class FSDHRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _apiUsername;
        private readonly string _apiPassword;

        /*
         * This repository currently sets individual properties from configuration.
         * To reduce possibilities for errors, we would like to encapsulate all configuration properties in
         * a class and inject the configuration class
         * Question: How would you achieve the objective above?
         */
        public FSDHRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiUsername = configuration["Username"];
            _apiPassword = configuration["Password"];
        }
        public async Task<bool> ValidateUserCredentials(string username,string password)
        {
            await Task.Delay(3000);
            return true;
        }


        /*
         * Question:
         * 1. What do you understand by Database Transactions?
         * 2. Using the LoanContext class, how would you perform multiple database operations within a database transaction.
         * 
         */

        public async Task PerformMultipleDatabaseOperations()
        {
            // LoanContext


        }
    }
}
