using DiGi.EPW.Classes;
using System.Collections.Generic;

namespace DiGi.EPW
{
    public static partial class Create
    {
        /// <summary>
        /// Parses typical/extreme periods data from a specific line within an array of strings to create a list of <see cref="TypicalExtremePeriod"/> objects.
        /// </summary>
        /// <param name="lines">The array of strings containing the raw data lines.</param>
        /// <param name="index">The index of the line to be processed.</param>
        /// <param name="index_Next">An output parameter that returns the updated index after processing.</param>
        /// <returns>A list of <see cref="TypicalExtremePeriod"/> instances if the input is valid; otherwise, null.</returns>
        public static List<TypicalExtremePeriod>? TypicalExtremePeriods(string[]? lines, int index, out int index_Next)
        {
            index_Next = -1;

            if (lines == null || lines.Length == 0)
            {
                return null;
            }

            if (index < 0 || index >= lines.Length)
            {
                return null;
            }

            string line = lines[index].Trim();

            string[] values = line.Split(',');

            List<TypicalExtremePeriod> result = [];
            for (int i = 2; i + 3 < values.Length; i += 4)
            {
                TypicalExtremePeriod typicalExtremePeriod = new(values[i], values[i + 1], values[i + 2], values[i + 3]);
                result.Add(typicalExtremePeriod);
            }

            index_Next = index + 1;

            return result;
        }
    }
}
