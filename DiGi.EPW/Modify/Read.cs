using DiGi.EPW.Classes;

namespace DiGi.EPW
{
    public static partial class Modify
    {
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

                if (line_Upper.StartsWith(Constans.HeaderName.Location))
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