using FSDHInterview.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHInterview.Services
{
    /*
     * Question6:
     * The authentication service below consumes another service called FSDHRepository.
     * The authentication service is registered as a singleton while repository service
     * is registered as a scoped service.
     * An error is thrown when you try to start the project.
     * Question: 
     * 1. What is the problem?
     * 2. How would you fix it?
     */
    public class AuthenticationService
    {
        private readonly FSDHRepository _repository;

        public AuthenticationService(FSDHRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Login(string username, string password)
        {
            return await _repository.ValidateUserCredentials(username, password);
        }
    }
}
