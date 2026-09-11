using DiGi.EPW.Classes;
using System;

namespace DiGi.EPW
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the measured snow depth, in cm, of the given hourly data record.
        /// <para>Returns null when the raw <see cref="DiGi.Weather.Classes.WeatherRecord.SnowDepth"/> equals the EPW missing-value marker <see cref="Constants.MissingValue.SnowDepth"/> (999), so a missing reading is distinguishable from a measurement without comparing against a magic number.</para>
        /// </summary>
        /// <param name="dataRecord">The hourly data record to query.</param>
        /// <returns>The measured snow depth, in cm, or null when the reading is missing.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided data record is null.</exception>
        public static float? SnowDepthValue(this DataRecord dataRecord)
        {
            if (dataRecord is null)
            {
                throw new ArgumentNullException(nameof(dataRecord));
            }

            float snowDepth = dataRecord.SnowDepth;
            return snowDepth == Constants.MissingValue.SnowDepth ? null : snowDepth;
        }
    }
}
