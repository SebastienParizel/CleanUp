using System;
using System.Linq;

namespace CleanUp.Interpreter
{
    public class DirectoryPathArgument : ArgumentInterpreter
    {
        public override string GetHelpMessage()
        {
            return "-p: Directory path to clean up (clean-up is recursive)";
        }

        public override void InterpretContext(ArgumentContext context)
        {
            var path = context.Arguments
                              .Where(a => a.StartsWith("-p"))
                              .FirstOrDefault();
            if (!string.IsNullOrEmpty(path))
            {
                context.DirectoryPath = path.Substring(3);
            }
        }
    }
}
