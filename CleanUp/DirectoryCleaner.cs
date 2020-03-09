using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp
{
    public class DirectoryCleaner
    {
        private readonly string[] _patternName;
        private readonly ConsoleWriter _console;

        public DirectoryCleaner(string[] patternName, ConsoleWriter console)
        {
            _console = console ?? throw new ArgumentNullException(nameof(console));
            _patternName = patternName ?? throw new ArgumentNullException(nameof(patternName));
            var log = new StringBuilder();
            log.Append($"Folder to remove:{Environment.NewLine}");
            foreach (var name in _patternName)
            {
                log.Append($"* {name}{Environment.NewLine}");
            }
            console.Trace(log.ToString());
        }

        public void CleanUpDirectory(string directoryPath)
        {
            var directory = new DirectoryInfo(directoryPath);
            foreach (var pattern in _patternName)
            {
                foreach (var dir in directory.GetDirectories(pattern))
                {
                    _console.Trace($"Removing directory \"{dir.FullName}\"");
                    dir.Delete(true);
                }
            }
            foreach (var subDirectory in directory.GetDirectories())
            {
                CleanUpDirectory(subDirectory.FullName);
            }
        }
    }
}
