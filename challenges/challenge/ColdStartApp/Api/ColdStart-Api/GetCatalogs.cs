using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ColdStart_Api.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

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
            var query = "SELECT * FROM [dbo].[Icecreams]";

            using var connection = GetDbConnectionAsync();
            var result = await connection.QueryAsync<Catalog>(query, commandType: CommandType.Text).ConfigureAwait(false);
            var list = result.ToList();
            return new OkObjectResult(list);
        }

        public IDbConnection GetDbConnectionAsync()
        {
            var sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable("DbConnectionString"));
            return sqlConnection;
        }
    }
}
