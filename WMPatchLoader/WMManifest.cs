using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMPatchLoader
{
    public class WMManifest
    {
        public string manifest { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string version { get; set; }
        public string cover { get; set; }
        public bool userValue { get; set; }
        public string description { get; set; }
        public IList<string> patchFiles { get; set; }
    }
}
