using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo.Models.Tables.Project
{
    //companyId:projectid, checklist
    [DynamoDBTable(TABLE_NAME)]
    public class ProjectCheckList : CheckListBaseModel
    {
        public const String TABLE_NAME = "_Projects";

        [DynamoDBHashKey]
        public string PartitionKey { get; set; }

        [DynamoDBRangeKey]
        public string ObjectPath { get; set; }
    }
}
