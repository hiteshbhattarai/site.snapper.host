using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using site.snapper.dynamo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo
{

    [DynamoDBTable(TABLE_NAME)]
    public class Photo : SystemMetadata
    {
        public const String TABLE_NAME = "_Photos";

        [DynamoDBHashKey]
        public string PartitionKey { get; set; }  // COMPANYID::PHOTO

        [DynamoDBRangeKey]
        public string ObjectPath { get; set; } // project id
        public string BucketPath { get; set; } = null!;
        public string Caption { get; set; } = null!;

        public Coordinate Coordinate { get; set; }

        public string Description { get; set; }


        public ICollection<Tags> Tags { get; set; }
        public ICollection<Comment> Comments { get; set; } 
    }

  
}
