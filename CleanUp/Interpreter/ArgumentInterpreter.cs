using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Interpreter
{
    public abstract class ArgumentInterpreter
    {
        public abstract void InterpretContext(ArgumentContext context);

        public abstract string GetHelpMessage();
    }
}
