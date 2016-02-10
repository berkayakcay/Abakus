using System.Collections.Generic;

namespace Count
{
    class WriteTextFile
    {
        public static void RW(List<string> barcodes, string filename)
        {
            System.IO.File.WriteAllLines(@"Export/"+filename+".txt", barcodes.ToArray());
        }   // Writes barcodes list to export folder as filename

    }
}
