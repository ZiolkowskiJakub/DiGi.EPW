using DiGi.EPW.Classes;
using System.Collections.Generic;

namespace DiGi.EPW
{
    public static partial class Modify
    {
        /// <summary>
        /// Writes an <see cref="EPWFile"/> instance to the specified path as an EPW file.
        /// </summary>
        /// <param name="epwFile">The EPW file data to be written.</param>
        /// <param name="path">The file system path the EPW file is written to.</param>
        /// <returns><c>true</c> if the EPW file is successfully written; otherwise, <c>false</c>.</returns>
        public static bool Write(this EPWFile? epwFile, string? path)
        {
            if (epwFile == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            List<string> lines = [];

            lines.Add(epwFile.Location != null ? Query.ToString(epwFile.Location) : Constants.HeaderName.Location);
            lines.Add(epwFile.DesignConditions != null ? Query.ToString(epwFile.DesignConditions) : string.Format("{0},0", Constants.HeaderName.DesignConditions));
            lines.Add(epwFile.TypicalExtremePeriods != null ? Query.ToString(epwFile.TypicalExtremePeriods) : string.Format("{0},0", Constants.HeaderName.TypicalExtremePeriods));
            lines.Add(epwFile.GroundTemperatures != null ? Query.ToString(epwFile.GroundTemperatures) : string.Format("{0},0", Constants.HeaderName.GroundTemperatures));
            lines.Add(epwFile.HolidaysDaylightSaving != null ? Query.ToString(epwFile.HolidaysDaylightSaving) : string.Format("{0},No,0,0,0", Constants.HeaderName.HolidaysDaylightSavings));
            lines.Add(string.Format("{0},{1}", Constants.HeaderName.Comments1, epwFile.Comments1 ?? string.Empty));
            lines.Add(string.Format("{0},{1}", Constants.HeaderName.Comments2, epwFile.Comments2 ?? string.Empty));

            IList<DataRecord>? dataRecords = epwFile.DataRecords;
            int recordsPerHour = 1;

            lines.Add(epwFile.DataPeriods != null ? Query.ToString(epwFile.DataPeriods, recordsPerHour) : string.Format("{0},0,{1}", Constants.HeaderName.DataPeriods, recordsPerHour));

            if (dataRecords != null)
            {
                foreach (DataRecord dataRecord in dataRecords)
                {
                    lines.Add(Query.ToString(dataRecord));
                }
            }

            System.IO.File.WriteAllLines(path, lines);

            return true;
        }
    }
}
