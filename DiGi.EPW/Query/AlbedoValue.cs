using DiGi.EPW.Classes;
using System;

namespace DiGi.EPW
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the measured albedo, dimensionless, of the given hourly data record.
        /// <para>Returns null when the raw <see cref="DataRecord.Albedo"/> equals the EPW missing-value marker <see cref="Constants.MissingValue.Albedo"/> (999), so a missing reading is distinguishable from a measurement without comparing against a magic number. A raw value of 0 is not a marker and is returned as is; deciding whether a zero albedo is usable belongs to the consumer.</para>
        /// </summary>
        /// <param name="dataRecord">The hourly data record to query.</param>
        /// <returns>The measured albedo, dimensionless, or null when the reading is missing.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided data record is null.</exception>
        public static float? AlbedoValue(this DataRecord dataRecord)
        {
            if (dataRecord is null)
            {
                throw new ArgumentNullException(nameof(dataRecord));
            }

            float albedo = dataRecord.Albedo;
            return albedo == Constants.MissingValue.Albedo ? null : albedo;
        }
    }
}
