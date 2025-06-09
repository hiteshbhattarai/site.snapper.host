using Amazon.DynamoDBv2;
using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo.Clients
{
    public class SnapperDynamoClient
    {
        public readonly AmazonDynamoDBClient Client;

        public SnapperDynamoClient(SnapperAwsCredential cred)
        {



            if (!String.IsNullOrEmpty(cred.AccessKey))
            {
                AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
                clientConfig.RegionEndpoint = cred.RegionEndpoint;

                Client = new AmazonDynamoDBClient(cred.AccessKey, cred.SecretKey, clientConfig);
            }
            else
            {

                Client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
            }
        }
    }

    public class SnapperAwsCredential
    {

        public String TablePrefix { get; set; }

        public const String AWS_ACCESS_KEY = nameof(AWS_ACCESS_KEY);
        public const String AWS_SECRET_KEY = nameof(AWS_SECRET_KEY);

        public String AccessKey { get; set; }

        public String SecretKey { get; set; }

        public RegionEndpoint RegionEndpoint { get; set; }
    }

}
