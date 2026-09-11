using DiGi.EPW.Classes;
using System;

namespace DiGi.EPW
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the measured direct normal radiation, in Wh/m2, of the given hourly data record.
        /// <para>Returns null when the raw <see cref="DiGi.Weather.Classes.WeatherRecord.DirectNormalRadiation"/> equals the EPW missing-value marker <see cref="Constants.MissingValue.DirectNormalRadiation"/> (9999), so a missing reading is distinguishable from a measurement without comparing against a magic number.</para>
        /// </summary>
        /// <param name="dataRecord">The hourly data record to query.</param>
        /// <returns>The measured direct normal radiation, in Wh/m2, or null when the reading is missing.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided data record is null.</exception>
        public static float? DirectNormalRadiationValue(this DataRecord dataRecord)
        {
            if (dataRecord is null)
            {
                throw new ArgumentNullException(nameof(dataRecord));
            }

            float directNormalRadiation = dataRecord.DirectNormalRadiation;
            return directNormalRadiation == Constants.MissingValue.DirectNormalRadiation ? null : directNormalRadiation;
        }
    }
}
