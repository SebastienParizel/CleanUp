using System.Linq;

namespace CleanUp.Interpreter
{
    public class IntermediateArgument : ArgumentInterpreter
    {
        public override string GetHelpMessage()
        {
            return "-i: remove intermediate (obj folder)";
        }

        public override void InterpretContext(ArgumentContext context)
        {
            if (context.Arguments.Contains("-i"))
            {
                context.PatternDirectory.Add("obj");
                context.PatternDirectory.Add(".vs");
            }
        }
    }
}
