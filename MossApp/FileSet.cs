using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MossApp
{
    public class FileSet
    {
        public string FirstFile { get; set; }

        public string SecondFile { get; set; }

        public int LinesMatched { get; set; }

        public Uri Url { get; set; }
    }
}
