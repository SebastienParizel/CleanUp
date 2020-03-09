using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Interpreter
{
    public class HelpArgument : ArgumentInterpreter
    {
        public override string GetHelpMessage()
        {
            return string.Empty;
        }

        public override void InterpretContext(ArgumentContext context)
        {
            if (context.Arguments.Contains("-?"))
            {
                var builder = new StringBuilder();
                builder.Append($"Help to clean up your .net repository by removing some working folder:{Environment.NewLine}");
                foreach (var interpret in Interpretter.Instance.Interpretters)
                {
                    builder.Append($"{interpret.GetHelpMessage()}{Environment.NewLine}");
                }
                context.HelpMessage = builder.ToString();
            }
        }
    }
}
