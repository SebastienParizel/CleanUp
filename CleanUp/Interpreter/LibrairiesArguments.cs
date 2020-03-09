using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Interpreter
{
    public class LibrairiesArguments : ArgumentInterpreter
    {
        public override string GetHelpMessage()
        {
            return "-l: remove librairies (packages folder)";
        }

        public override void InterpretContext(ArgumentContext context)
        {
            if (context.Arguments.Contains("-l"))
            {
                context.PatternDirectory.Add("packages");
            }
        }
    }
}
