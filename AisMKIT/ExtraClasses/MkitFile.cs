using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AisMKIT.ExtraClasses
{
    public class MkitFile
    {

        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public byte[] Bytes { get; set; }
    }
}
