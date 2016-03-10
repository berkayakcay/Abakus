using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count.Model
{
    public class CountDetail : Count
    {
        public string Barcode { get; set; }
        public string Qty { get; set; }
    }
}
