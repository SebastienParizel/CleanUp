using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Interpreter
{
    public class Interpretter
    {
        private static Interpretter _instance = new Interpretter();
        public static Interpretter Instance => _instance;

        private readonly List<ArgumentInterpreter> _interpretters;

        public IEnumerable<ArgumentInterpreter> Interpretters => _interpretters;

        private Interpretter()
        {
            _interpretters = new List<ArgumentInterpreter>{
                new LibrairiesArguments(),
                new OutputArgument(),
                new IntermediateArgument(),
                new HelpArgument(),
                new DirectoryPathArgument()
            };
        }

        public void Interpret(ArgumentContext context)
        {
            foreach (var interpretter in _interpretters)
            {
                interpretter.InterpretContext(context);
            }
        }
    }
}
