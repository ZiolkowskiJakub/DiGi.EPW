using DiGi.EPW.Classes;
using System.Collections.Generic;

namespace DiGi.EPW
{
    public static partial class Create
    {
        public static Dictionary<string, EPWFile> EPWFiles(string directory, System.IO.SearchOption searchOption)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory))
            {
                return null;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constans.FileExtension.EPWFile), searchOption);
            if (paths == null || paths.Length == 0)
            {
                return null;
            }

            Dictionary<string, EPWFile> result = new Dictionary<string, EPWFile>();
            foreach (string path in paths)
            {
                EPWFile ePWFile = EPW.Modify.Read(path);
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

