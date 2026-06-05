using DiGi.EPW.Classes;

namespace DiGi.EPW
{
    public static partial class Modify
    {
        /// <summary>
        /// Reads an EPW file from the specified path and parses it into an <see cref="EPWFile"/> object.
        /// </summary>
        /// <param name="path">The file system path to the EPW file.</param>
        /// <returns>An <see cref="EPWFile"/> instance if the file is successfully read; otherwise, <c>null</c>.</returns>
        public static EPWFile? Read(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines == null || lines.Length == 0)
            {
                return null;
            }

            Location? location = null;

            int count = lines.Length;

            int index = 0;

            while (index < count)
            {
                string line = lines[index].Trim();

                string line_Upper = line.ToUpper();

                if (line_Upper.StartsWith("!") || line_Upper.StartsWith("\\"))
                {
                    index++;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.Location))
                {
                    location = Create.Location(lines, index, out int index_Next);
                    if (location != null && index_Next != -1)
                    {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
                        index = index_Next;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
                    }

                    break;
                }

                index++;
            }

            return new EPWFile(location);
        }
    }
}