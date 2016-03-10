using System;
using System.Collections.Generic;
using System.Text;

namespace Count.Model
{
    public class Warehouse
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Code;
        }

    }
}
