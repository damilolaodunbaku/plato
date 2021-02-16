using FSDHInterview.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHInterview.DTO
{
    public class LoanRequestDTO
    {
        public int CustomerId { get; set; }
        public LoanType LoanType { get; set; }
    }
}
