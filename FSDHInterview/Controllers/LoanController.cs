using FSDHInterview.Business;
using FSDHInterview.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        /*
         * Question3:
         * The CredentialsDTO class below is used to receive customer username and password when a customer signs-up
         * The class needs the following validation
         * 1. Username is mandatory and must be longer than 6 characters.
         * 2. Username should be a valid email address
         * 3. Password is also mandatory and must be at least 8 characters
         * 4. Password should include at least a capital letter, a small letter, a special character
         */
        [HttpPost("credential")]
        public async Task<ActionResult> CreateCredential([FromBody] CredentialsDTO credentialsDTO)
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

        /*
         * Question4:
         * Assume that the code in the action method below calls an api.
         * 1. Complete the code portion to make an HTTP Get request and return the status code
         * 2. Optimize the code to inject the HttpClient instance via dependency injection.
         * 
         * 
         * 
         */
        [HttpGet("history")]
        public async Task<ActionResult> RetrieveLoanHistory()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://google.com");


                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
