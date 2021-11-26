using System;

namespace CodeWalker.CLI
{
    /// <summary>
    /// Helper class used to format different numbers.
    /// </summary>
    public static class Readable
    {
        /// <summary>
        /// Formats a number for a file size.
        /// </summary>
        /// <param name="number">The file size in bytes.</param>
        /// <returns>A string with the human readable storage size (for example 3.4 GB)</returns>
        public static string FileSize(long number)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (number == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(number);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(number) * num).ToString() + " " + suf[place];
        }
        /// <summary>
        /// Formats a bool into Yes or No.
        /// </summary>
        /// <param name="toggle">The bool to format.</param>
        /// <returns>A string that says Yes or No based on the bool.</returns>
        public static string YesNo(bool toggle) => toggle ? "Yes" : "No";
    }
}
