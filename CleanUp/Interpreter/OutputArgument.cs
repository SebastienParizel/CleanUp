using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Interpreter
{
    public class OutputArgument : ArgumentInterpreter
    {
        public override string GetHelpMessage()
        {
            return "-o: remove output (bin folder)";
        }

        public override void InterpretContext(ArgumentContext context)
        {
            if (context.Arguments.Contains("-o"))
            {
                context.PatternDirectory.Add("bin");
            }
        }
    }
}
