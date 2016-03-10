using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count.Model
{
    [Serializable]
    public class LocalData
    {
        public string Name { get; set; }
        public string FileExtension { get; set; }
        public string Version { get; set; }
    }
}
