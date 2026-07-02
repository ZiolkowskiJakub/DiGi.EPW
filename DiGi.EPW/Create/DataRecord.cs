using DiGi.EPW.Classes;
using System;
using System.Globalization;

namespace DiGi.EPW
{
    /// <summary>
    /// Provides factory methods for creating EPW-related data models.
    /// </summary>
    public static partial class Create
    {
        /// <summary>
        /// Parses an hourly weather data record from a specific line within an array of strings to create a <see cref="DataRecord"/> object.
        /// </summary>
        /// <param name="lines">The array of strings containing the raw data lines.</param>
        /// <param name="index">The index of the line to be processed.</param>
        /// <param name="index_Next">An output parameter that returns the updated index after processing.</param>
        /// <returns>A <see cref="DataRecord"/> instance if the input is valid; otherwise, null.</returns>
        public static DataRecord? DataRecord(string[]? lines, int index, out int index_Next)
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
            if (string.IsNullOrWhiteSpace(line))
            {
                return null;
            }

            string[] values = line.Split(',');
            if (values.Length < 35)
            {
                return null;
            }

            int.TryParse(values[0], NumberStyles.Any, CultureInfo.InvariantCulture, out int year);
            int.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out int month);
            int.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out int day);
            int.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out int hour);
            int.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out int minute);

            string? dataSourceAndUncertaintyFlags = values[5];

            float.TryParse(values[6], NumberStyles.Any, CultureInfo.InvariantCulture, out float dryBulbTemperature);
            float.TryParse(values[7], NumberStyles.Any, CultureInfo.InvariantCulture, out float dewPointTemperature);
            float.TryParse(values[8], NumberStyles.Any, CultureInfo.InvariantCulture, out float relativeHumidity);
            float.TryParse(values[9], NumberStyles.Any, CultureInfo.InvariantCulture, out float atmosphericStationPressure);
            float.TryParse(values[10], NumberStyles.Any, CultureInfo.InvariantCulture, out float extraterrestrialHorizontalRadiation);
            float.TryParse(values[11], NumberStyles.Any, CultureInfo.InvariantCulture, out float extraterrestrialDirectNormalRadiation);
            float.TryParse(values[12], NumberStyles.Any, CultureInfo.InvariantCulture, out float horizontalInfraredRadiationIntensity);
            float.TryParse(values[13], NumberStyles.Any, CultureInfo.InvariantCulture, out float globalHorizontalRadiation);
            float.TryParse(values[14], NumberStyles.Any, CultureInfo.InvariantCulture, out float directNormalRadiation);
            float.TryParse(values[15], NumberStyles.Any, CultureInfo.InvariantCulture, out float diffuseHorizontalRadiation);
            float.TryParse(values[16], NumberStyles.Any, CultureInfo.InvariantCulture, out float globalHorizontalIlluminance);
            float.TryParse(values[17], NumberStyles.Any, CultureInfo.InvariantCulture, out float directNormalIlluminance);
            float.TryParse(values[18], NumberStyles.Any, CultureInfo.InvariantCulture, out float diffuseHorizontalIlluminance);
            float.TryParse(values[19], NumberStyles.Any, CultureInfo.InvariantCulture, out float zenithLuminance);
            float.TryParse(values[20], NumberStyles.Any, CultureInfo.InvariantCulture, out float windDirection);
            float.TryParse(values[21], NumberStyles.Any, CultureInfo.InvariantCulture, out float windSpeed);

            int.TryParse(values[22], NumberStyles.Any, CultureInfo.InvariantCulture, out int totalSkyCover);
            int.TryParse(values[23], NumberStyles.Any, CultureInfo.InvariantCulture, out int opaqueSkyCover);

            float.TryParse(values[24], NumberStyles.Any, CultureInfo.InvariantCulture, out float visibility);
            float.TryParse(values[25], NumberStyles.Any, CultureInfo.InvariantCulture, out float ceilingHeight);

            int.TryParse(values[26], NumberStyles.Any, CultureInfo.InvariantCulture, out int presentWeatherObservation);
            string? presentWeatherCodes = values[27];

            float.TryParse(values[28], NumberStyles.Any, CultureInfo.InvariantCulture, out float precipitableWater);
            float.TryParse(values[29], NumberStyles.Any, CultureInfo.InvariantCulture, out float aerosolOpticalDepth);
            float.TryParse(values[30], NumberStyles.Any, CultureInfo.InvariantCulture, out float snowDepth);

            int.TryParse(values[31], NumberStyles.Any, CultureInfo.InvariantCulture, out int daysSinceLastSnowfall);

            float.TryParse(values[32], NumberStyles.Any, CultureInfo.InvariantCulture, out float albedo);
            float.TryParse(values[33], NumberStyles.Any, CultureInfo.InvariantCulture, out float liquidPrecipitationDepth);
            float.TryParse(values[34], NumberStyles.Any, CultureInfo.InvariantCulture, out float liquidPrecipitationQuantity);

            index_Next = index + 1;

            DateTime dateTime = Convert.ToSystem_DateTime(year, month, day, hour, minute);

            return new DataRecord(
                dateTime,
                dataSourceAndUncertaintyFlags,
                dryBulbTemperature,
                dewPointTemperature,
                relativeHumidity,
                atmosphericStationPressure,
                extraterrestrialHorizontalRadiation,
                extraterrestrialDirectNormalRadiation,
                horizontalInfraredRadiationIntensity,
                globalHorizontalRadiation,
                directNormalRadiation,
                diffuseHorizontalRadiation,
                globalHorizontalIlluminance,
                directNormalIlluminance,
                diffuseHorizontalIlluminance,
                zenithLuminance,
                windDirection,
                windSpeed,
                totalSkyCover,
                opaqueSkyCover,
                visibility,
                ceilingHeight,
                presentWeatherObservation,
                presentWeatherCodes,
                precipitableWater,
                aerosolOpticalDepth,
                snowDepth,
                daysSinceLastSnowfall,
                albedo,
                liquidPrecipitationDepth,
                liquidPrecipitationQuantity);
        }
    }
}