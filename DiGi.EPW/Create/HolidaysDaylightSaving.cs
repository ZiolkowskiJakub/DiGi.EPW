using DiGi.EPW.Classes;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.EPW
{
    public static partial class Create
    {
        /// <summary>
        /// Parses holidays/daylight saving data from a specific line within an array of strings to create a <see cref="HolidaysDaylightSaving"/> object.
        /// </summary>
        /// <param name="lines">The array of strings containing the raw data lines.</param>
        /// <param name="index">The index of the line to be processed.</param>
        /// <param name="index_Next">An output parameter that returns the updated index after processing.</param>
        /// <returns>A <see cref="HolidaysDaylightSaving"/> instance if the input is valid; otherwise, null.</returns>
        public static HolidaysDaylightSaving? HolidaysDaylightSaving(string[]? lines, int index, out int index_Next)
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

            bool leapYearObserved = false;
            string? daylightSavingStartDate = null;
            string? daylightSavingEndDate = null;
            int numberOfHolidays = 0;

            if (values.Length > 1)
            {
                leapYearObserved = string.Equals(values[1], "Yes", System.StringComparison.OrdinalIgnoreCase);
            }

            if (values.Length > 2)
            {
                daylightSavingStartDate = values[2];
            }

            if (values.Length > 3)
            {
                daylightSavingEndDate = values[3];
            }

            if (values.Length > 4)
            {
                int.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out numberOfHolidays);
            }

            List<Holiday> holidays = [];

            int pointer = 5;
            for (int i = 0; i < numberOfHolidays; i++)
            {
                if (pointer + 1 >= values.Length)
                {
                    break;
                }

                Holiday holiday = new(values[pointer], values[pointer + 1]);
                holidays.Add(holiday);

                pointer += 2;
            }

            index_Next = index + 1;

            return new HolidaysDaylightSaving(leapYearObserved, daylightSavingStartDate, daylightSavingEndDate, holidays);
        }
    }
}
