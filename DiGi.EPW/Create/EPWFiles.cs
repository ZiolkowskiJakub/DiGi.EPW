using DiGi.EPW.Classes;
using System.Collections.Generic;

namespace DiGi.EPW
{
    public static partial class Create
    {
        /// <summary>
        /// Scans the specified directory for files with the EPW extension and reads them into a dictionary mapping file paths to <see cref="EPWFile"/> objects.
        /// </summary>
        /// <param name="directory">The path to the directory to search.</param>
        /// <param name="searchOption">Specifies whether to search only the current directory or include subdirectories.</param>
        /// <returns>A dictionary of file paths and their corresponding <see cref="EPWFile"/> objects, or null if the directory is invalid or no files are found.</returns>
        public static Dictionary<string, EPWFile>? EPWFiles(string? directory, System.IO.SearchOption searchOption)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory))
            {
                return null;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constants.FileExtension.EPWFile), searchOption);
            if (paths == null || paths.Length == 0)
            {
                return null;
            }

            Dictionary<string, EPWFile> result = [];
            foreach (string path in paths)
            {
                EPWFile? ePWFile = Modify.Read(path);
                if (ePWFile == null)
                {
                    continue;
                }

                result[path] = ePWFile;
            }

            return result;
        }
    }
}