using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo
{
    //companyId:projectid, task
    [DynamoDBTable(TABLE_NAME)]
    public class ProjectTask
    {
        public const String TABLE_NAME = "_Projects";

        [DynamoDBHashKey]
        public string PartitionKey { get; set; } // COMPANYID::PROJECTID

        [DynamoDBRangeKey]
        public string ObjectPath { get; set; } // PROJECT_TASK

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public By CompletedBy { get; set; }

        public DateTime CompletedAt { get; set; }

    }
}
