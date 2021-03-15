using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.CognitiveServices.Personalizer;
using System.Collections.Generic;
using ColdStart_Api.Models;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.Azure.CognitiveServices.Personalizer.Models;

namespace ColdStart_Api
{
    public  class GetRecommendation
    {
        [FunctionName("GetRecommendation")]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "recommendation")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var client = InitializePersonalizerClient();
            
            var currentContext = GetContextFeatures(req);
            var actions = await GetActions();
            string eventId = Guid.NewGuid().ToString();
            IList<string> excludeActions = new List<string>();

            var request = new RankRequest(actions, currentContext, excludeActions, eventId);
            RankResponse response = client.Rank(request);
            var recommendationDetail = new RecommendationDetail();
            recommendationDetail.EventId = response.EventId;
            recommendationDetail.RewardActionId = response.RewardActionId;
            return new OkObjectResult(recommendationDetail);
        }

        public PersonalizerClient InitializePersonalizerClient()
        {
            PersonalizerClient client = new PersonalizerClient(
                new ApiKeyServiceClientCredentials(Environment.GetEnvironmentVariable("PersonalizerApiKey")))
            { Endpoint = Environment.GetEnvironmentVariable("PersonalizerServiceEndpoint") };

            return client;
        }

        public  async Task<IList<Catalog>> GetAllCatelogs()
        {
            var query = "SELECT * FROM [dbo].[Icecreams]";

            using var connection = GetDbConnectionAsync();
            var result = await connection.QueryAsync<Catalog>(query, commandType: CommandType.Text).ConfigureAwait(false);
            var list = result.ToList();
            return list;
        }
        public IDbConnection GetDbConnectionAsync()
        {
            var sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable("DbConnectionString"));
            return sqlConnection;
        }

        public async Task<IList<RankableAction>> GetActions()
        {
            IList<RankableAction> actions = new List<RankableAction>();
            var catalogs = await GetAllCatelogs();

            foreach (Catalog catalog in catalogs)
            {
                var action = new RankableAction
                {
                    Id = catalog?.Id.ToString(),
                    Features =
                        new List<object>() {
                            new {
                                Id = catalog.Id,
                                Name = catalog.Name,
                                Description = catalog.Description,
                                ImageUrl = catalog.ImageUrl,
                            }
                        }
                };
                actions.Add(action);
            }
            return actions;


        }

        public IList<object> GetContextFeatures(HttpRequest req)
        {
            IList<object> currentContext = new List<object>() {
                new { timeOfDay = GetUsersTimeOfDay() },
                new { dayOfWeek = DateTime.Now.DayOfWeek },
                new { browserType = req.Headers["User-Agent"].ToString()},
                new { loggedInUser = GetClientPrincipal(req)},
            };
            return currentContext;
        }
        public static string GetUsersTimeOfDay()
        {
            string time;
            string[] timeOfDayFeatures = new string[] { "morning", "afternoon", "evening", "night" };

            int hour = DateTime.Now.Hour;
            if(hour >= 0 && hour < 7 || hour > 21)
            {
                time = timeOfDayFeatures[3];
            }else if(hour >= 7 && hour < 12)
            {
                time = timeOfDayFeatures[0];
            }
            else if (hour >= 12 && hour < 4)
            {
                time = timeOfDayFeatures[1];
            }
            else
            {
                time = timeOfDayFeatures[2];
            }

            return time;
        }
        public static string GetClientPrincipal(HttpRequest req)
        {
            var principal = new ClientPrincipal();
            if (req.Headers.TryGetValue("x-ms-client-principal", out var header))
            {
                var data = header[0];
                var decoded = Convert.FromBase64String(data);
                var json = Encoding.ASCII.GetString(decoded);
                principal = JsonConvert.DeserializeObject<ClientPrincipal>(json);
            }
            return principal.UserDetails;
        }
        public class ClientPrincipal
        {
            public string IdentityProvider { get; set; }
            public string UserId { get; set; }
            public string UserDetails { get; set; } = "John Doe";
            public IEnumerable<string> UserRoles { get; set; }
        }
    }
}
