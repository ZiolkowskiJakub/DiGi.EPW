using DiGi.EPW.Classes;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.EPW
{
    public static partial class Create
    {
        /// <summary>
        /// Parses data periods data from a specific line within an array of strings to create a list of <see cref="DataPeriod"/> objects.
        /// </summary>
        /// <param name="lines">The array of strings containing the raw data lines.</param>
        /// <param name="index">The index of the line to be processed.</param>
        /// <param name="recordsPerHour">An output parameter that returns the number of records per hour declared in the record.</param>
        /// <param name="index_Next">An output parameter that returns the updated index after processing.</param>
        /// <returns>A list of <see cref="DataPeriod"/> instances if the input is valid; otherwise, null.</returns>
        public static List<DataPeriod>? DataPeriods(string[]? lines, int index, out int recordsPerHour, out int index_Next)
        {
            index_Next = -1;
            recordsPerHour = 1;

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

            int count = 0;
            if (values.Length > 1)
            {
                int.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out count);
            }

            if (values.Length > 2)
            {
                int.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out recordsPerHour);
            }

            List<DataPeriod> result = [];

            int pointer = 3;
            for (int i = 0; i < count; i++)
            {
                if (pointer + 3 >= values.Length)
                {
                    break;
                }

                DataPeriod dataPeriod = new(values[pointer], values[pointer + 1], values[pointer + 2], values[pointer + 3]);
                result.Add(dataPeriod);

                pointer += 4;
            }

            index_Next = index + 1;

            return result;
        }
    }
}
