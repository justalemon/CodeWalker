using CommandLine;
using System;

namespace CodeWalker.CLI
{
    /// <summary>
    /// The main entry point of the CodeWalker CLI.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The parsed CLI arguments.
        /// </summary>
        public static Arguments Arguments { get; set; }

        /// <summary>
        /// The main entry point.
        /// </summary>
        /// <param name="args">The arguments passed to the executable.</param>
        public static int Main(string[] args)
        {
            int exitCode = 0;

            ParserResult<Arguments> arguments = Parser.Default.ParseArguments<Arguments>(args);

            if (arguments.Tag == ParserResultType.NotParsed)
            {
                exitCode = 1;
                return exitCode;
            }

            arguments.WithParsed(x => Arguments = x);

            return exitCode;
        }
    }
}
