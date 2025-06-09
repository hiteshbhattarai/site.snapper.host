using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo
{

    /// <summary>
    /// Tags Template Summary
    /// <example>
    /// <code>
    /// PartitionKey = CompanyId::TAGS
    /// ObjectPath = 
    /// </code>
    /// </example>
    /// </summary>
    /// 
    [DynamoDBTable(TABLE_NAME)]
    public class Tags
    {
        public string Name { get; set; }

        public const String TABLE_NAME = "_Snapper_Attributes";

        [DynamoDBHashKey]
        public string PartitionKey { get; set; }  // company id

        [DynamoDBRangeKey]
        public string ObjectPath { get; set; }  // TAGS
    }
}
