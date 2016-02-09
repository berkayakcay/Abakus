using System;
using System.Collections.Generic;
using System.Text;

namespace Count
{
    class WriteTextFile
    {
        public static void RW(List<string> barcodes, string filename)
        {
            System.IO.File.WriteAllLines(@"Export/"+filename+".txt", barcodes.ToArray());

        }

    }
}
