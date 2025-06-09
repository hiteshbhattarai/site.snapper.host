using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo
{
    public class CheckListBaseModel : SystemMetadata
    {
        public String Name { get; set; }
        public ICollection<By> Assignees { get; set; }
        public ICollection<ChecklistItem> Items { get; set; }
    }
}
