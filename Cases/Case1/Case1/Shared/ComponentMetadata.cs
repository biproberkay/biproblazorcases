using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.Shared
{
    public class ComponentMetadata
    {
        public string? Name { get; set; }
        public Dictionary<string, object> Parameters { get; set; } =
            new Dictionary<string, object>();
    }
}
