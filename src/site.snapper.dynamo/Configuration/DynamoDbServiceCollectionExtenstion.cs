using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.Extensions.DependencyInjection;
using site.snapper.dynamo.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo.Configuration
{
    public static class DynamoDbServiceCollectionExtenstion
    {
        public static IServiceCollection AddSnapperDynamoClient(this IServiceCollection services)
        {
            var config = new SnapperAwsCredential
            {
                AccessKey = Environment.GetEnvironmentVariable(SnapperAwsCredential.AWS_ACCESS_KEY),
                SecretKey = Environment.GetEnvironmentVariable(SnapperAwsCredential.AWS_SECRET_KEY),
                RegionEndpoint = RegionEndpoint.USEast1,
                TablePrefix = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToLower() == "development" ? "dev_" : "prod_",
                
            };

          
            var client = new SnapperDynamoClient(config);

            services.AddSingleton(sp => config);

            services.AddSingleton(sp => client);
            DynamoDBContextConfig c = new DynamoDBContextConfig()
            {
                TableNamePrefix = config.TablePrefix
            };
            var context = new DynamoDBContextBuilder()
                    .WithDynamoDBClient(() => client.Client)
                    .ConfigureContext(config => new DynamoDBContextConfig { TableNamePrefix = config.TableNamePrefix, Conversion = DynamoDBEntryConversion.V2 })
                    .Build();

            services.AddSingleton<IDynamoDBContext>(sp => context);

            return services;
        }
    }
}
