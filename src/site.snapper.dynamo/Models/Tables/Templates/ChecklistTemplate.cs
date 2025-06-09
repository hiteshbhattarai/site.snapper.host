using Amazon.DynamoDBv2.DataModel;

namespace site.snapper.dynamo
{

    /// <summary>
    /// CheckList Template Summary
    /// <example>
    /// <code>
    /// PartitionKey = CompanyId::CHECK_LIST_TEMPLATE
    /// ObjectPath = 
    /// </code>
    /// </example>
    /// </summary>
    /// 
    [DynamoDBTable(TABLE_NAME)]
    public class ChecklistTemplate : CheckListBaseModel
    {
        public const String TABLE_NAME = "_Snapper_Attributes";

        [DynamoDBHashKey]
        public string PartitionKey { get; set; }  // company id

        [DynamoDBRangeKey]
        public string ObjectPath { get; set; }  // CHECK_LIST_TEMPLATE
    }
}
