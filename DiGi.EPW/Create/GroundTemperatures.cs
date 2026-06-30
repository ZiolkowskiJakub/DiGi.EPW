using DiGi.EPW.Classes;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.EPW
{
    public static partial class Create
    {
        /// <summary>
        /// Parses ground temperatures data from a specific line within an array of strings to create a list of <see cref="GroundTemperature"/> objects.
        /// </summary>
        /// <param name="lines">The array of strings containing the raw data lines.</param>
        /// <param name="index">The index of the line to be processed.</param>
        /// <param name="index_Next">An output parameter that returns the updated index after processing.</param>
        /// <returns>A list of <see cref="GroundTemperature"/> instances if the input is valid; otherwise, null.</returns>
        public static List<GroundTemperature>? GroundTemperatures(string[]? lines, int index, out int index_Next)
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

            int count = 0;
            if (values.Length > 1)
            {
                int.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out count);
            }

            List<GroundTemperature> result = [];

            int pointer = 2;
            for (int i = 0; i < count; i++)
            {
                if (pointer + 15 >= values.Length)
                {
                    break;
                }

                double.TryParse(values[pointer], NumberStyles.Any, CultureInfo.InvariantCulture, out double depth);

                double? conductivity = null;
                if (double.TryParse(values[pointer + 1], NumberStyles.Any, CultureInfo.InvariantCulture, out double conductivity_Temp))
                {
                    conductivity = conductivity_Temp;
                }

                double? density = null;
                if (double.TryParse(values[pointer + 2], NumberStyles.Any, CultureInfo.InvariantCulture, out double density_Temp))
                {
                    density = density_Temp;
                }

                double? specificHeat = null;
                if (double.TryParse(values[pointer + 3], NumberStyles.Any, CultureInfo.InvariantCulture, out double specificHeat_Temp))
                {
                    specificHeat = specificHeat_Temp;
                }

                List<double> monthlyValues = [];
                for (int j = 0; j < 12; j++)
                {
                    double monthlyValue = 0;
                    double.TryParse(values[pointer + 4 + j], NumberStyles.Any, CultureInfo.InvariantCulture, out monthlyValue);
                    monthlyValues.Add(monthlyValue);
                }

                GroundTemperature groundTemperature = new(depth, conductivity, density, specificHeat, monthlyValues);
                result.Add(groundTemperature);

                pointer += 16;
            }

            index_Next = index + 1;

            return result;
        }
    }
}
