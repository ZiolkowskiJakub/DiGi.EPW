using DiGi.EPW.Classes;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.EPW
{
    public static partial class Create
    {
        /// <summary>
        /// Parses design conditions data from a specific line within an array of strings to create a <see cref="DesignConditions"/> object.
        /// </summary>
        /// <param name="lines">The array of strings containing the raw data lines.</param>
        /// <param name="index">The index of the line to be processed.</param>
        /// <param name="index_Next">An output parameter that returns the updated index after processing.</param>
        /// <returns>A <see cref="DesignConditions"/> instance if the input is valid; otherwise, null.</returns>
        public static DesignConditions? DesignConditions(string[]? lines, int index, out int index_Next)
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

            int numberOfDesignConditions = 0;
            string? source = null;
            string? name = null;

            if (values.Length > 1)
            {
                int.TryParse(values[1], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out numberOfDesignConditions);
            }

            if (values.Length > 2)
            {
                source = values[2];
            }

            if (values.Length > 3)
            {
                name = values[3];
            }

            int index_Heating = System.Array.FindIndex(values, value => string.Equals(value, "Heating", System.StringComparison.OrdinalIgnoreCase));
            int index_Cooling = System.Array.FindIndex(values, value => string.Equals(value, "Cooling", System.StringComparison.OrdinalIgnoreCase));
            int index_Extremes = System.Array.FindIndex(values, value => string.Equals(value, "Extremes", System.StringComparison.OrdinalIgnoreCase));

            List<double>? heatingValues = null;
            List<double>? coolingValues = null;
            List<double>? extremeValues = null;

            if (index_Heating != -1)
            {
                int index_End = index_Cooling != -1 ? index_Cooling : values.Length;

                heatingValues = [];
                for (int i = index_Heating + 1; i < index_End; i++)
                {
                    double heatingValue = 0;
                    double.TryParse(values[i], NumberStyles.Any, CultureInfo.InvariantCulture, out heatingValue);
                    heatingValues.Add(heatingValue);
                }
            }

            if (index_Cooling != -1)
            {
                int index_End = index_Extremes != -1 ? index_Extremes : values.Length;

                coolingValues = [];
                for (int i = index_Cooling + 1; i < index_End; i++)
                {
                    double.TryParse(values[i], NumberStyles.Any, CultureInfo.InvariantCulture, out double coolingValue);
                    coolingValues.Add(coolingValue);
                }
            }

            if (index_Extremes != -1)
            {
                extremeValues = [];
                for (int i = index_Extremes + 1; i < values.Length; i++)
                {
                    double.TryParse(values[i], NumberStyles.Any, CultureInfo.InvariantCulture, out double extremeValue);
                    extremeValues.Add(extremeValue);
                }
            }

            index_Next = index + 1;

            return new DesignConditions(numberOfDesignConditions, source, name, heatingValues, coolingValues, extremeValues);
        }
    }
}