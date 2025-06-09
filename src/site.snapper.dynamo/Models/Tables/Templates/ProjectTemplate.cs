

using Amazon.DynamoDBv2.DataModel;

namespace site.snapper.dynamo
{

    /// <summary>
    /// Project  Summary
    /// <example>
    /// <code>
    /// PartitionKey = CompanyId::Project
    /// ObjectPath = 
    /// </code>
    /// </example>
    /// </summary>
    /// 
    [DynamoDBTable(TABLE_NAME)]
    public class ProjectTemplate : ProjectBaseModel
    {
        public const String TABLE_NAME = "_Snapper_Attributes";

        [DynamoDBHashKey]
        public string PartitionKey { get; set; }  // company id

        [DynamoDBRangeKey]
        public string ObjectPath { get; set; }  // PROJECT_TEMPLATE
    }
}
