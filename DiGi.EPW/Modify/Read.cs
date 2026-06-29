using DiGi.EPW.Classes;
using System.Collections.Generic;

namespace DiGi.EPW
{
    public static partial class Modify
    {
        /// <summary>
        /// Reads an EPW file from the specified path and parses it into an <see cref="EPWFile"/> object.
        /// </summary>
        /// <param name="path">The file system path to the EPW file.</param>
        /// <returns>An <see cref="EPWFile"/> instance if the file is successfully read; otherwise, <c>null</c>.</returns>
        public static EPWFile? Read(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines == null || lines.Length == 0)
            {
                return null;
            }

            Location? location = null;
            Classes.DesignConditions? designConditions = null;
            List<TypicalExtremePeriod>? typicalExtremePeriods = null;
            List<GroundTemperature>? groundTemperatures = null;
            Classes.HolidaysDaylightSaving? holidaysDaylightSaving = null;
            string? comments1 = null;
            string? comments2 = null;
            List<DataPeriod>? dataPeriods = null;

            int count = lines.Length;

            int index = 0;

            while (index < count)
            {
                string line = lines[index].Trim();

                string line_Upper = line.ToUpper();

                if (line_Upper.StartsWith("!") || line_Upper.StartsWith("\\"))
                {
                    index++;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.Location))
                {
                    location = Create.Location(lines, index, out int index_Next);
                    index = index_Next != -1 ? index_Next : index + 1;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.DesignConditions))
                {
                    designConditions = Create.DesignConditions(lines, index, out int index_Next);
                    index = index_Next != -1 ? index_Next : index + 1;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.TypicalExtremePeriods))
                {
                    typicalExtremePeriods = Create.TypicalExtremePeriods(lines, index, out int index_Next);
                    index = index_Next != -1 ? index_Next : index + 1;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.GroundTemperatures))
                {
                    groundTemperatures = Create.GroundTemperatures(lines, index, out int index_Next);
                    index = index_Next != -1 ? index_Next : index + 1;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.HolidaysDaylightSavings))
                {
                    holidaysDaylightSaving = Create.HolidaysDaylightSaving(lines, index, out int index_Next);
                    index = index_Next != -1 ? index_Next : index + 1;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.Comments1))
                {
                    int index_Comma = line.IndexOf(',');
                    comments1 = index_Comma != -1 ? line.Substring(index_Comma + 1).Trim().Trim('"') : null;
                    index++;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.Comments2))
                {
                    int index_Comma = line.IndexOf(',');
                    comments2 = index_Comma != -1 ? line.Substring(index_Comma + 1).Trim().Trim('"') : null;
                    index++;
                    continue;
                }

                if (line_Upper.StartsWith(Constants.HeaderName.DataPeriods))
                {
                    dataPeriods = Create.DataPeriods(lines, index, out int recordsPerHour_Temp, out int index_Next);
                    index = index_Next != -1 ? index_Next : index + 1;
                    break;
                }

                index++;
            }

            List<DataRecord> dataRecords = [];
            while (index < count)
            {
                string line = lines[index].Trim();
                if (string.IsNullOrWhiteSpace(line))
                {
                    index++;
                    continue;
                }

                DataRecord? dataRecord = Create.DataRecord(lines, index, out int index_Next);
                if (dataRecord != null)
                {
                    dataRecords.Add(dataRecord);
                }

                index = index_Next != -1 ? index_Next : index + 1;
            }

            return new EPWFile(location, designConditions, typicalExtremePeriods, groundTemperatures, holidaysDaylightSaving, comments1, comments2, dataPeriods, dataRecords);
        }
    }
}
