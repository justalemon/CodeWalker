using CommandLine;

namespace CodeWalker.CLI
{
    /// <summary>
    /// The allowed Command Line Interface arguments.
    /// </summary>
    public class Arguments
    {
        /// <summary>
        /// The source RPF file to modify.
        /// </summary>
        [Option('s', "source", HelpText = "The RPF File to use.", Required = true)]
        public string Source { get; set; }

        /// <summary>
        /// Shows the info of the 
        /// </summary>
        [Option('i', "info", HelpText = "Show the information of the Source RPF and exit.", Group = "operations")]
        public bool Operation { get; set; }
    }
}
