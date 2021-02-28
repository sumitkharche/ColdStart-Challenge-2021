using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using ColdStart_Api.Helpers;

namespace ColdStart_Api
{
    public class GetCatalogs
    {
        private readonly HttpClient _httpClient;
        public GetCatalogs(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [FunctionName("GetCatalogs")]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "catalogs")] HttpRequest req,
            ILogger log)
        {

            log.LogInformation("C# HTTP trigger function processed a request.");

            var catalogs = MockData.GetCatalogs();

            return new OkObjectResult(catalogs);
        }
    }
}
