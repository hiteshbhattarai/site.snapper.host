using Amazon.DynamoDBv2.DataModel;

namespace site.snapper.dynamo
{

    /// <summary>
    /// Label Template Summary
    /// <example>
    /// <code>
    /// PartitionKey = CompanyId::LABEL
    /// ObjectPath = 
    /// </code>
    /// </example>
    /// </summary>
    public class Label
    {

        public const String TABLE_NAME = "_Snapper_Attributes";

        [DynamoDBHashKey]
        public string PartitionKey { get; set; }  // company id

        [DynamoDBRangeKey]
        public string ObjectPath { get; set; }  // Label
        public string Name { get; set; }
        public string Color { get; set; }

    }
}
