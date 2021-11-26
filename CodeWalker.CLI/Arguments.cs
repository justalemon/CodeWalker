using CommandLine;

namespace CodeWalker.CLI
{
    /// <summary>
    /// The allowed Command Line Interface arguments.
    /// </summary>
    public class Arguments
    {
        [Option('s', "source", HelpText = "The RPF File to use.", Required = true)]
        public string Source { get; set; }

        [Option('v', "verbose", HelpText = "If the information should be verbose.")]
        public bool Verbose { get; set; }

        [Option('i', "info", HelpText = "Show the information of the Source RPF and exit.")]
        public bool Info { get; set; }
    }
}
