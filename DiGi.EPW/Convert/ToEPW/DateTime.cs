using System;

namespace DiGi.EPW
{
    /// <summary>
    /// Extension and helper methods for converting data types to EPW representations.
    /// </summary>
    public static partial class Convert
    {
        /// <summary>
        /// Decomposes a standard <see cref="DateTime"/> instance back into EPW-compliant datetime components.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> to decompose.</param>
        /// <param name="year">The output year.</param>
        /// <param name="month">The output month.</param>
        /// <param name="day">The output day.</param>
        /// <param name="hour">The output hour (1-24).</param>
        /// <param name="minute">The output minute (0-60).</param>
        public static void ToEPW_DateTime(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute)
        {
            if (dateTime.Hour == 0 && dateTime.Minute == 0 && dateTime.Second == 0)
            {
                DateTime dateTime_Previous = dateTime.AddDays(-1);
                year = dateTime_Previous.Year;
                month = dateTime_Previous.Month;
                day = dateTime_Previous.Day;
                hour = 24;
                minute = 60;
            }
            else
            {
                year = dateTime.Year;
                month = dateTime.Month;
                day = dateTime.Day;
                if (dateTime.Minute == 0)
                {
                    hour = dateTime.Hour;
                    minute = 60;
                }
                else
                {
                    hour = dateTime.Hour + 1;
                    minute = dateTime.Minute;
                }
            }
        }
    }
}