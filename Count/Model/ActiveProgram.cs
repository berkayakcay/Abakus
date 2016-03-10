using System;
using System.Collections.Generic;

using System.Text;

namespace Count.Model
{
    public class ActiveProgram
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
