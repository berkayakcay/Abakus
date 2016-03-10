using System;
using System.Collections.Generic;

using System.Text;

namespace Count.Model
{
    public class Count
    {
        public string Name { get; set; }
        public bool IsNew { get; set; }
        public bool IsOnline { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
