using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsValidPassword("@Password123"));
            //Console.WriteLine(IsValidPassword("@Password123"));

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ProcessMultipleTransactions();
            stopwatch.Stop();

            Console.WriteLine($"Total seconds to process transactions is {stopwatch.Elapsed.TotalSeconds}");
            
            //int uniqueCharacters = GetUniqueCharacters("Massachussets");
            //Console.WriteLine($"The string Massachussets contains {uniqueCharacters} unique characters");
        }

        /*
         * Given an input string, validate that the input string meets the following criteria.
         *
         * 1. Input string contains at least one lower case charater.
         * 2. Input string contains at least one upper case charater.
         * 3. Input string contains at least one digit charater.
         * 4. Input string contains at least a special charater.
         * 5. Input string is at least 8 characters long.
         *
         * If all conditions are met, return true otherwise return false.
         */
        private static bool IsValidPassword(string inputString)
        {
            return false;
        }

        /*
         * The method below initiates processes transactions for 5000 customers.
         * For each customer, an API Call is made to initiate the transaction and the 
         * transaction details are saved to a database.
         * 
         * The current implementation works fine but can take some time to complete.
         * 
         * Can you optimize this method to process through the items faster?
         * 
         */
        private static void ProcessMultipleTransactions()
        {
            IEnumerable<int> customerIds = Enumerable.Range(1, 5000);

            Infrastructure infrastructure = new Infrastructure();

            foreach (int id in customerIds)
            {
                Console.WriteLine($"Processing transaction for customer with ID: {id}");

                var transactionDetails = infrastructure.InitiateAPITransaction(id).Result;
                infrastructure.SaveTransactionDetails(transactionDetails).Wait();

                Console.WriteLine($"Processing completed successfully for customer with ID: {id}");
            }
        }

        /*
         * Write a function to return the number of unique characters in a string.
         * 
         * 
         * 
         */
        private static int GetUniqueCharacters(string input)
        {
            return 0;
        }
    }
}
