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

            int year = 0;
            int.TryParse(values[0], NumberStyles.Any, CultureInfo.InvariantCulture, out year);

            int month = 0;
            int.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out month);

            int day = 0;
            int.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out day);

            int hour = 0;
            int.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out hour);

            int minute = 0;
            int.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out minute);

            string? dataSourceAndUncertaintyFlags = values[5];

            double dryBulbTemperature = 0;
            double.TryParse(values[6], NumberStyles.Any, CultureInfo.InvariantCulture, out dryBulbTemperature);

            double dewPointTemperature = 0;
            double.TryParse(values[7], NumberStyles.Any, CultureInfo.InvariantCulture, out dewPointTemperature);

            double relativeHumidity = 0;
            double.TryParse(values[8], NumberStyles.Any, CultureInfo.InvariantCulture, out relativeHumidity);

            double atmosphericStationPressure = 0;
            double.TryParse(values[9], NumberStyles.Any, CultureInfo.InvariantCulture, out atmosphericStationPressure);

            double extraterrestrialHorizontalRadiation = 0;
            double.TryParse(values[10], NumberStyles.Any, CultureInfo.InvariantCulture, out extraterrestrialHorizontalRadiation);

            double extraterrestrialDirectNormalRadiation = 0;
            double.TryParse(values[11], NumberStyles.Any, CultureInfo.InvariantCulture, out extraterrestrialDirectNormalRadiation);

            double horizontalInfraredRadiationIntensity = 0;
            double.TryParse(values[12], NumberStyles.Any, CultureInfo.InvariantCulture, out horizontalInfraredRadiationIntensity);

            double globalHorizontalRadiation = 0;
            double.TryParse(values[13], NumberStyles.Any, CultureInfo.InvariantCulture, out globalHorizontalRadiation);

            double directNormalRadiation = 0;
            double.TryParse(values[14], NumberStyles.Any, CultureInfo.InvariantCulture, out directNormalRadiation);

            double diffuseHorizontalRadiation = 0;
            double.TryParse(values[15], NumberStyles.Any, CultureInfo.InvariantCulture, out diffuseHorizontalRadiation);

            double globalHorizontalIlluminance = 0;
            double.TryParse(values[16], NumberStyles.Any, CultureInfo.InvariantCulture, out globalHorizontalIlluminance);

            double directNormalIlluminance = 0;
            double.TryParse(values[17], NumberStyles.Any, CultureInfo.InvariantCulture, out directNormalIlluminance);

            double diffuseHorizontalIlluminance = 0;
            double.TryParse(values[18], NumberStyles.Any, CultureInfo.InvariantCulture, out diffuseHorizontalIlluminance);

            double zenithLuminance = 0;
            double.TryParse(values[19], NumberStyles.Any, CultureInfo.InvariantCulture, out zenithLuminance);

            double windDirection = 0;
            double.TryParse(values[20], NumberStyles.Any, CultureInfo.InvariantCulture, out windDirection);

            double windSpeed = 0;
            double.TryParse(values[21], NumberStyles.Any, CultureInfo.InvariantCulture, out windSpeed);

            int totalSkyCover = 0;
            int.TryParse(values[22], NumberStyles.Any, CultureInfo.InvariantCulture, out totalSkyCover);

            int opaqueSkyCover = 0;
            int.TryParse(values[23], NumberStyles.Any, CultureInfo.InvariantCulture, out opaqueSkyCover);

            double visibility = 0;
            double.TryParse(values[24], NumberStyles.Any, CultureInfo.InvariantCulture, out visibility);

            double ceilingHeight = 0;
            double.TryParse(values[25], NumberStyles.Any, CultureInfo.InvariantCulture, out ceilingHeight);

            int presentWeatherObservation = 0;
            int.TryParse(values[26], NumberStyles.Any, CultureInfo.InvariantCulture, out presentWeatherObservation);

            string? presentWeatherCodes = values[27];

            double precipitableWater = 0;
            double.TryParse(values[28], NumberStyles.Any, CultureInfo.InvariantCulture, out precipitableWater);

            double aerosolOpticalDepth = 0;
            double.TryParse(values[29], NumberStyles.Any, CultureInfo.InvariantCulture, out aerosolOpticalDepth);

            double snowDepth = 0;
            double.TryParse(values[30], NumberStyles.Any, CultureInfo.InvariantCulture, out snowDepth);

            int daysSinceLastSnowfall = 0;
            int.TryParse(values[31], NumberStyles.Any, CultureInfo.InvariantCulture, out daysSinceLastSnowfall);

            double albedo = 0;
            double.TryParse(values[32], NumberStyles.Any, CultureInfo.InvariantCulture, out albedo);

            double liquidPrecipitationDepth = 0;
            double.TryParse(values[33], NumberStyles.Any, CultureInfo.InvariantCulture, out liquidPrecipitationDepth);

            double liquidPrecipitationQuantity = 0;
            double.TryParse(values[34], NumberStyles.Any, CultureInfo.InvariantCulture, out liquidPrecipitationQuantity);

            index_Next = index + 1;

            return new DataRecord(year, month, day, hour, minute, dataSourceAndUncertaintyFlags, dryBulbTemperature, dewPointTemperature, relativeHumidity, atmosphericStationPressure, extraterrestrialHorizontalRadiation, extraterrestrialDirectNormalRadiation, horizontalInfraredRadiationIntensity, globalHorizontalRadiation, directNormalRadiation, diffuseHorizontalRadiation, globalHorizontalIlluminance, directNormalIlluminance, diffuseHorizontalIlluminance, zenithLuminance, windDirection, windSpeed, totalSkyCover, opaqueSkyCover, visibility, ceilingHeight, presentWeatherObservation, presentWeatherCodes, precipitableWater, aerosolOpticalDepth, snowDepth, daysSinceLastSnowfall, albedo, liquidPrecipitationDepth, liquidPrecipitationQuantity);
        }
    }
}
