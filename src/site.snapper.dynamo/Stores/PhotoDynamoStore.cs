using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using site.snapper.dynamo.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo.Stores
{
    public class PhotoDynamoStore
    {
        private readonly SnapperDynamoClient _snapperDynamoClient;
        private readonly IDynamoDBContext _context;
       

        public PhotoDynamoStore(SnapperDynamoClient snapperDynamoClient, IDynamoDBContext context)
        {
            this._snapperDynamoClient = snapperDynamoClient ?? throw new ArgumentNullException(nameof(snapperDynamoClient));


            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        //public async Task<DynamoIdentityPolicy> AddPhoto(string companyId, string path, string projectId, CancellationToken cancellationToken)
        //{
        //    cancellationToken.ThrowIfCancellationRequested();

        //    var photo = new Photo { 
        //     PartitionKey = $"{companyId}::PHOTO",
        //     ObjectPath = projectId,
        //     BucketPath = path,
        //     CreateAt = DateTime.UtcNow,
        //     CreatedBy = 
        //    };


        //    DynamoDBOperationConfig c = new DynamoDBOperationConfig();
        //    c.TableNamePrefix = _config.TablePrefix;
        //    await _context.SaveAsync(policyData, c, cancellationToken);
        //    return policyData;
        //}
    }
}
