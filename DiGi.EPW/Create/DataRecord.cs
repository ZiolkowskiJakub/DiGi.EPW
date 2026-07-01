using DiGi.EPW.Classes;
using System.Globalization;

namespace DiGi.EPW
{
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

            double.TryParse(values[6], NumberStyles.Any, CultureInfo.InvariantCulture, out double dryBulbTemperature);

            double.TryParse(values[7], NumberStyles.Any, CultureInfo.InvariantCulture, out double dewPointTemperature);

            double.TryParse(values[8], NumberStyles.Any, CultureInfo.InvariantCulture, out double relativeHumidity);

            double.TryParse(values[9], NumberStyles.Any, CultureInfo.InvariantCulture, out double atmosphericStationPressure);

            double.TryParse(values[10], NumberStyles.Any, CultureInfo.InvariantCulture, out double extraterrestrialHorizontalRadiation);

            double.TryParse(values[11], NumberStyles.Any, CultureInfo.InvariantCulture, out double extraterrestrialDirectNormalRadiation);

            double.TryParse(values[12], NumberStyles.Any, CultureInfo.InvariantCulture, out double horizontalInfraredRadiationIntensity);

            double.TryParse(values[13], NumberStyles.Any, CultureInfo.InvariantCulture, out double globalHorizontalRadiation);

            double.TryParse(values[14], NumberStyles.Any, CultureInfo.InvariantCulture, out double directNormalRadiation);

            double.TryParse(values[15], NumberStyles.Any, CultureInfo.InvariantCulture, out double diffuseHorizontalRadiation);

            double.TryParse(values[16], NumberStyles.Any, CultureInfo.InvariantCulture, out double globalHorizontalIlluminance);

            double.TryParse(values[17], NumberStyles.Any, CultureInfo.InvariantCulture, out double directNormalIlluminance);

            double.TryParse(values[18], NumberStyles.Any, CultureInfo.InvariantCulture, out double diffuseHorizontalIlluminance);

            double.TryParse(values[19], NumberStyles.Any, CultureInfo.InvariantCulture, out double zenithLuminance);

            double.TryParse(values[20], NumberStyles.Any, CultureInfo.InvariantCulture, out double windDirection);

            double.TryParse(values[21], NumberStyles.Any, CultureInfo.InvariantCulture, out double windSpeed);

            int.TryParse(values[22], NumberStyles.Any, CultureInfo.InvariantCulture, out int totalSkyCover);

            int.TryParse(values[23], NumberStyles.Any, CultureInfo.InvariantCulture, out int opaqueSkyCover);

            double.TryParse(values[24], NumberStyles.Any, CultureInfo.InvariantCulture, out double visibility);

            double.TryParse(values[25], NumberStyles.Any, CultureInfo.InvariantCulture, out double ceilingHeight);

            int.TryParse(values[26], NumberStyles.Any, CultureInfo.InvariantCulture, out int presentWeatherObservation);

            string? presentWeatherCodes = values[27];

            double.TryParse(values[28], NumberStyles.Any, CultureInfo.InvariantCulture, out double precipitableWater);

            double.TryParse(values[29], NumberStyles.Any, CultureInfo.InvariantCulture, out double aerosolOpticalDepth);

            double.TryParse(values[30], NumberStyles.Any, CultureInfo.InvariantCulture, out double snowDepth);

            int.TryParse(values[31], NumberStyles.Any, CultureInfo.InvariantCulture, out int daysSinceLastSnowfall);

            double.TryParse(values[32], NumberStyles.Any, CultureInfo.InvariantCulture, out double albedo);

            double.TryParse(values[33], NumberStyles.Any, CultureInfo.InvariantCulture, out double liquidPrecipitationDepth);

            double.TryParse(values[34], NumberStyles.Any, CultureInfo.InvariantCulture, out double liquidPrecipitationQuantity);

            index_Next = index + 1;

            return new DataRecord(year, month, day, hour, minute, dataSourceAndUncertaintyFlags, dryBulbTemperature, dewPointTemperature, relativeHumidity, atmosphericStationPressure, extraterrestrialHorizontalRadiation, extraterrestrialDirectNormalRadiation, horizontalInfraredRadiationIntensity, globalHorizontalRadiation, directNormalRadiation, diffuseHorizontalRadiation, globalHorizontalIlluminance, directNormalIlluminance, diffuseHorizontalIlluminance, zenithLuminance, windDirection, windSpeed, totalSkyCover, opaqueSkyCover, visibility, ceilingHeight, presentWeatherObservation, presentWeatherCodes, precipitableWater, aerosolOpticalDepth, snowDepth, daysSinceLastSnowfall, albedo, liquidPrecipitationDepth, liquidPrecipitationQuantity);
        }
    }
}