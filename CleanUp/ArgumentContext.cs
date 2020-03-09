using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp
{
    public class ArgumentContext
    {
        public string[] Arguments { get; set; }

        public List<string> PatternDirectory { get; set; } = new List<string>();

        public string DirectoryPath { get; set; }

        public string HelpMessage { get; set; }
    }
}
