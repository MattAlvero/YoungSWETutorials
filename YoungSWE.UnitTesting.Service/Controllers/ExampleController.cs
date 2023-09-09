using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YoungSWE.UnitTesting.Domain.Models;
using YoungSWE.UnitTesting.Infrastructure.Interfaces;

namespace YoungSWE.UnitTesting.API.Controllers
{
    [ApiController]
    [Route("ExampleAPI")]
    public class ExampleController : ControllerBase
    {

        private readonly ILogger<ExampleController> _logger;
        private readonly IExampleService exampleService;
        public ExampleController(ILogger<ExampleController> logger, IExampleService exampleService)
        {
            _logger = logger;
            this.exampleService = exampleService;
        }

        [HttpGet(Name = "GetPerson")]
        public string GetPerson(string firstName)
        {
            _logger.BeginScope($"GetPerson invoked with paramter {firstName}");
            string request = exampleService.GetPerson(firstName);
            string result = JsonConvert.SerializeObject(request);
            _logger.LogInformation(firstName, result);
            return result;
        }
    }
}