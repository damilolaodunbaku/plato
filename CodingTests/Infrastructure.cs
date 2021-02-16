using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTests
{
    class Infrastructure
    {
        /// <summary>
        /// Initiate a transaction for a customer via an API call
        /// </summary>
        /// <param name="id">The customer id</param>
        /// <returns>The customer balance</returns>
        public async Task<string> InitiateAPITransaction(int id)
        {
            //Simulate a network request
            await Task.Delay(1000);
            return (100m * id).ToString();
        }

        /// <summary>
        /// Save transaction details to a database
        /// </summary>
        /// <param name="serializedTransactionDetails">The serialized transaction</param>
        /// <returns></returns>
        public async Task SaveTransactionDetails(string serializedTransactionDetails)
        {
            await Task.Delay(600);
            return;
        }
    }
}
