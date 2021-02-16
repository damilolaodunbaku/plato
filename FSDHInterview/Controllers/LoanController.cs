using FSDHInterview.Business;
using FSDHInterview.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHInterview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {

        [HttpPost()]
        public async Task<ActionResult> RequestLoan([FromBody] LoanRequestDTO loanRequestDTO)
        {
            try
            {

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
