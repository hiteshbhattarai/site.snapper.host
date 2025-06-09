using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.snapper.dynamo
{
    public class Comment
    {
        public string Text { get; set; }
        public By User { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
