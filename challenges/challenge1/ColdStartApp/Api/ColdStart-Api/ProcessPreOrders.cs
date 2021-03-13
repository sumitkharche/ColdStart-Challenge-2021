using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ColdStart_Api.Models;
using Dapper;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ColdStart_Api
{
    public class ProcessPreOrders
    {
        [FunctionName("ProcessPreOrders")]
        public async Task Run([QueueTrigger("icecreames-order-queue", Connection = "StorageQueueConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

            var preOrderMessage = JsonConvert.DeserializeObject<PreOrderMessage>(myQueueItem);
            var preOrder = JsonConvert.DeserializeObject<Order>(preOrderMessage.Value);
            int result = 0;
            if (preOrder == null)
                return;

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

                using var connection =  GetDbConnectionAsync();
                result = await connection.ExecuteScalarAsync<int>(sqlStatement, parameters, commandType: CommandType.Text).ConfigureAwait(false);

                log.LogInformation($"Pre order is stored for user : {preOrder.User} and pre-order Id: {result}");
            }
            catch (Exception ex)
            {
                log.LogError($"Failed to save Pre order." +
                    $" Exception : {ex}");
            }
        }
        public IDbConnection GetDbConnectionAsync()
        {
            var sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable("DbConnectionString"));
            return sqlConnection;
        }
    }
}
