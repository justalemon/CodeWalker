using CodeWalker.GameFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWalker.CLI
{
    /// <summary>
    /// Manipulates RPF files.
    /// </summary>
    public static class RPF
    {
        /// <summary>
        /// Shows the information of a specific RPF file.
        /// </summary>
        /// <param name="rpf">The RPF file to load.</param>
        public static void ShowInfo(string rpf)
        {
            RpfFile file = new RpfFile(rpf, "/");

            file.EnsureAllEntries();

            Console.WriteLine($"Name: {file.Name}");
            Console.WriteLine($"File Size: {Readable.FileSize(file.FileSize)}");
            Console.WriteLine($"AES Encrypted: {Readable.YesNo(file.IsAESEncrypted)}");
            Console.WriteLine($"NG Encrypted: {Readable.YesNo(file.IsNGEncrypted)}");
            Console.WriteLine($"Number of Entries: {file.EntryCount}");

            if (Program.Arguments.Verbose)
            {
                Console.WriteLine("Entries:");

                foreach (RpfEntry entry in file.AllEntries)
                {
                    Console.WriteLine($"\t{entry.Path}");
                }
            }
        }
    }
}
