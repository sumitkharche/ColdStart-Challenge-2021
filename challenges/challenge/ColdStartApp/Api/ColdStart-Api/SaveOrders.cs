using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text;
using ColdStart_Api.Models;
using System.Data;
using Dapper;
using System.Net;
using System.Data.SqlClient;
using Microsoft.Azure.CognitiveServices.Personalizer;
using Microsoft.Azure.CognitiveServices.Personalizer.Models;

namespace ColdStart_Api
{
    public  class SaveOrders
    {
        [FunctionName("SaveOrders")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "order")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("ProcessPreOrders requested");
            string body = string.Empty;
            using (var reader = new StreamReader(req.Body, Encoding.UTF8))
            {
                body = await reader.ReadToEndAsync();
                log.LogInformation($"Create Pre-Order Request: {body}");
            }

            var preOrder = JsonConvert.DeserializeObject<Order>(body);
            int result = 0;
            if (preOrder == null)
                return new BadRequestResult();

            try
            {
                var sqlStatement = "INSERT INTO [dbo].[Orders] (Id, [User], Date, IcecreamId, Status, DriverId, FullAddress, LastPosition)" +
                                                      "VALUES (@Id, @User, @Date, @IcecreamId, @Status, @DriverId, @FullAddress, @LastPosition)" +
                                                      "SELECT @@identity";

                var parameters = new
                {
                    preOrder.Id,
                    preOrder.User,
                    preOrder.Date,
                    preOrder.IcecreamId,
                    preOrder.Status,
                    preOrder.DriverId,
                    preOrder.FullAddress,
                    preOrder.LastPosition
                };

                using var connection = GetDbConnectionAsync();
                result = await connection.ExecuteScalarAsync<int>(sqlStatement, parameters, commandType: CommandType.Text).ConfigureAwait(false);

                log.LogInformation($"Pre order is stored for user : {preOrder.User} and icecreamid: {preOrder.IcecreamId}");

                int reward = 1;
                var client = InitializePersonalizerClient();
                reward = preOrder.IcecreamId == Convert.ToInt32(preOrder.RecommendationDetails.RewardActionId) ? 1 : 0;
                client.Reward(preOrder.RecommendationDetails.EventId, new RewardRequest(reward));

                return new OkObjectResult("Pre Order saved successfully");
            }
            catch (Exception ex)
            {
                log.LogError($"Failed to save Pre order." +
                    $" Exception : {ex}");
                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    Content = $"Error Occured while saving pre order for user: {preOrder.User} icecreamid: {preOrder.IcecreamId}"
                };
            }
        }
        public IDbConnection GetDbConnectionAsync()
        {
            var sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable("DbConnectionString"));
            return sqlConnection;
        }
        public PersonalizerClient InitializePersonalizerClient()
        {
            PersonalizerClient client = new PersonalizerClient(
                new ApiKeyServiceClientCredentials(Environment.GetEnvironmentVariable("PersonalizerApiKey")))
            { Endpoint = Environment.GetEnvironmentVariable("PersonalizerServiceEndpoint") };

            return client;
        }


    }
}
