using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using FunctionExample.Services;

namespace FunctionExample.Functions
{
    public class GetUserFunction
    {
        private readonly ILogger<GetUserFunction> _logger;
        private readonly IGitHubService _githubService;
        public GetUserFunction(ILogger<GetUserFunction> logger, IGitHubService gitHubService)
        {
            _logger = logger;
            _githubService = gitHubService;
        }

        [FunctionName("GetUser")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            _logger.LogInformation("GetUser HTTP trigger function init.");

            try
            {
                string userName = req.Query["user"];
                if (string.IsNullOrEmpty(userName))
                {
                    return new ObjectResult("User parameter not provided.")
                    {
                        StatusCode = StatusCodes.Status400BadRequest,
                        ContentTypes = { "text/plain" }
                    };
                }

                var response = await _githubService.GetUser(userName);

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetUser exception: {ex}", ex);
                throw;
            }

            
        }
    }
}
