using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AgileCoding.Extentions.Streams
{
    public static class MemoryStreamExtentions
    {
        public static MemoryStream GetStreamForString(this MemoryStream stream, string data) 
        {
            stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);

            writer.Write(data);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
