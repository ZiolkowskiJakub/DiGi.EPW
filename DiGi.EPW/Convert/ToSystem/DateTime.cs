using System;

namespace DiGi.EPW
{
    /// <summary>
    /// Extension and helper methods for converting data types to System representations.
    /// </summary>
    public static partial class Convert
    {
        /// <summary>
        /// Converts EPW datetime components to a standard <see cref="DateTime"/> instance 
        /// using <see cref="DateTimeKind.Unspecified"/> to avoid timezone and DST issues.
        /// </summary>
        /// <param name="year">The year of the record.</param>
        /// <param name="month">The month of the record.</param>
        /// <param name="day">The day of the record.</param>
        /// <param name="hour">The hour of the record (1-24).</param>
        /// <param name="minute">The minute of the record (0-60).</param>
        /// <returns>A standard <see cref="DateTime"/> instance representing the exact instant.</returns>
        public static DateTime ToSystem_DateTime(int year, int month, int day, int hour, int minute)
        {
            DateTime dateTime_Base = new(year, month, day, 0, 0, 0, DateTimeKind.Unspecified);
            if (minute == 0 || minute == 60)
            {
                return dateTime_Base.AddHours(hour);
            }
            else
            {
                return dateTime_Base.AddHours(hour - 1).AddMinutes(minute);
            }
        }
    }
}
