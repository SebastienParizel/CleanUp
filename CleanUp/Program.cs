using CleanUp.Interpreter;
using System;
using System.Collections.Generic;

namespace CleanUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleWriter();
            //console.SetLevel(ConsoleLevel.Info);
            try
            {
                var context = new ArgumentContext
                {
                    Arguments = args
                };
                var interpretter = Interpretter.Instance;
                interpretter.Interpret(context);
                if (!string.IsNullOrEmpty(context.HelpMessage))
                {
                    console.Info(context.HelpMessage);
                }

                var cleaner = new DirectoryCleaner(context.PatternDirectory.ToArray(), console);
                console.Info($"Starting cleaning \"{context.DirectoryPath}\"");
                cleaner.CleanUpDirectory(context.DirectoryPath);
                console.Info($"Directory \"{context.DirectoryPath}\" clean");
            }catch(Exception e)
            {
                console.Warn(e.GetType().Name);
                console.Warn(e.Message);
                console.Warn(e.StackTrace);
            }
            console.Info("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
