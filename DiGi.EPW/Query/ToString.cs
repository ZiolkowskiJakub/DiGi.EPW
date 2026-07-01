using DiGi.EPW.Classes;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.EPW
{
    public static partial class Query
    {
        private static string ToInvariantString(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a <see cref="Location"/> instance into its EPW LOCATION header record line representation.
        /// </summary>
        /// <param name="location">The location to be converted.</param>
        /// <returns>The EPW LOCATION header record line.</returns>
        public static string ToString(this Location location)
        {
            return string.Join(",", Constants.HeaderName.Location, location.City, location.Region, location.Country, location.Source, location.WHO, ToInvariantString(location.Latitude), ToInvariantString(location.Longitude), ToInvariantString(location.TimeZone), ToInvariantString(location.Elevation));
        }

        /// <summary>
        /// Converts a <see cref="DesignConditions"/> instance into its EPW DESIGN CONDITIONS header record line representation.
        /// </summary>
        /// <param name="designConditions">The design conditions to be converted.</param>
        /// <returns>The EPW DESIGN CONDITIONS header record line.</returns>
        public static string ToString(this DesignConditions designConditions)
        {
            List<string> values = [Constants.HeaderName.DesignConditions, designConditions.NumberOfDesignConditions.ToString(CultureInfo.InvariantCulture), designConditions.Source ?? string.Empty, designConditions.Name ?? string.Empty];

            values.Add("Heating");
            if (designConditions.HeatingValues != null)
            {
                foreach (double heatingValue in designConditions.HeatingValues)
                {
                    values.Add(ToInvariantString(heatingValue));
                }
            }

            values.Add("Cooling");
            if (designConditions.CoolingValues != null)
            {
                foreach (double coolingValue in designConditions.CoolingValues)
                {
                    values.Add(ToInvariantString(coolingValue));
                }
            }

            values.Add("Extremes");
            if (designConditions.ExtremeValues != null)
            {
                foreach (double extremeValue in designConditions.ExtremeValues)
                {
                    values.Add(ToInvariantString(extremeValue));
                }
            }

            return string.Join(",", values);
        }

        /// <summary>
        /// Converts a list of <see cref="TypicalExtremePeriod"/> instances into their EPW TYPICAL/EXTREME PERIODS header record line representation.
        /// </summary>
        /// <param name="typicalExtremePeriods">The typical/extreme periods to be converted.</param>
        /// <returns>The EPW TYPICAL/EXTREME PERIODS header record line.</returns>
        public static string ToString(this IList<TypicalExtremePeriod> typicalExtremePeriods)
        {
            List<string> values = [Constants.HeaderName.TypicalExtremePeriods, typicalExtremePeriods.Count.ToString(CultureInfo.InvariantCulture)];

            foreach (TypicalExtremePeriod typicalExtremePeriod in typicalExtremePeriods)
            {
                values.Add(typicalExtremePeriod.Name ?? string.Empty);
                values.Add(typicalExtremePeriod.PeriodType ?? string.Empty);
                values.Add(typicalExtremePeriod.StartDate ?? string.Empty);
                values.Add(typicalExtremePeriod.EndDate ?? string.Empty);
            }

            return string.Join(",", values);
        }

        /// <summary>
        /// Converts a list of <see cref="GroundTemperature"/> instances into their EPW GROUND TEMPERATURES header record line representation.
        /// </summary>
        /// <param name="groundTemperatures">The ground temperatures to be converted.</param>
        /// <returns>The EPW GROUND TEMPERATURES header record line.</returns>
        public static string ToString(this IList<GroundTemperature> groundTemperatures)
        {
            List<string> values = [Constants.HeaderName.GroundTemperatures, groundTemperatures.Count.ToString(CultureInfo.InvariantCulture)];

            foreach (GroundTemperature groundTemperature in groundTemperatures)
            {
                values.Add(ToInvariantString(groundTemperature.Depth));
                values.Add(groundTemperature.Conductivity.HasValue ? ToInvariantString(groundTemperature.Conductivity.Value) : string.Empty);
                values.Add(groundTemperature.Density.HasValue ? ToInvariantString(groundTemperature.Density.Value) : string.Empty);
                values.Add(groundTemperature.SpecificHeat.HasValue ? ToInvariantString(groundTemperature.SpecificHeat.Value) : string.Empty);

                if (groundTemperature.MonthlyValues != null)
                {
                    foreach (double monthlyValue in groundTemperature.MonthlyValues)
                    {
                        values.Add(ToInvariantString(monthlyValue));
                    }
                }
            }

            return string.Join(",", values);
        }

        /// <summary>
        /// Converts a <see cref="HolidaysDaylightSaving"/> instance into its EPW HOLIDAYS/DAYLIGHT SAVINGS header record line representation.
        /// </summary>
        /// <param name="holidaysDaylightSaving">The holidays/daylight saving record to be converted.</param>
        /// <returns>The EPW HOLIDAYS/DAYLIGHT SAVINGS header record line.</returns>
        public static string ToString(this HolidaysDaylightSaving holidaysDaylightSaving)
        {
            IList<Holiday>? holidays = holidaysDaylightSaving.Holidays;

            List<string> values = [Constants.HeaderName.HolidaysDaylightSavings, holidaysDaylightSaving.LeapYearObserved ? "Yes" : "No", holidaysDaylightSaving.DaylightSavingStartDate ?? string.Empty, holidaysDaylightSaving.DaylightSavingEndDate ?? string.Empty, (holidays?.Count ?? 0).ToString(CultureInfo.InvariantCulture)];

            if (holidays != null)
            {
                foreach (Holiday holiday in holidays)
                {
                    values.Add(holiday.Name ?? string.Empty);
                    values.Add(holiday.Date ?? string.Empty);
                }
            }

            return string.Join(",", values);
        }

        /// <summary>
        /// Converts a list of <see cref="DataPeriod"/> instances into their EPW DATA PERIODS header record line representation.
        /// </summary>
        /// <param name="dataPeriods">The data periods to be converted.</param>
        /// <param name="recordsPerHour">The number of records per hour to be written into the record.</param>
        /// <returns>The EPW DATA PERIODS header record line.</returns>
        public static string ToString(this IList<DataPeriod> dataPeriods, int recordsPerHour)
        {
            List<string> values = [Constants.HeaderName.DataPeriods, dataPeriods.Count.ToString(CultureInfo.InvariantCulture), recordsPerHour.ToString(CultureInfo.InvariantCulture)];

            foreach (DataPeriod dataPeriod in dataPeriods)
            {
                values.Add(dataPeriod.Name ?? string.Empty);
                values.Add(dataPeriod.StartDayOfWeek ?? string.Empty);
                values.Add(dataPeriod.StartDate ?? string.Empty);
                values.Add(dataPeriod.EndDate ?? string.Empty);
            }

            return string.Join(",", values);
        }

        /// <summary>
        /// Converts a <see cref="DataRecord"/> instance into its EPW hourly weather data line representation.
        /// </summary>
        /// <param name="dataRecord">The data record to be converted.</param>
        /// <returns>The EPW hourly weather data line.</returns>
        public static string ToString(this DataRecord dataRecord)
        {
            List<string> values =
            [
                dataRecord.Year.ToString(CultureInfo.InvariantCulture),
                dataRecord.Month.ToString(CultureInfo.InvariantCulture),
                dataRecord.Day.ToString(CultureInfo.InvariantCulture),
                dataRecord.Hour.ToString(CultureInfo.InvariantCulture),
                dataRecord.Minute.ToString(CultureInfo.InvariantCulture),
                dataRecord.DataSourceAndUncertaintyFlags ?? string.Empty,
                ToInvariantString(dataRecord.DryBulbTemperature),
                ToInvariantString(dataRecord.DewPointTemperature),
                ToInvariantString(dataRecord.RelativeHumidity),
                ToInvariantString(dataRecord.AtmosphericStationPressure),
                ToInvariantString(dataRecord.ExtraterrestrialHorizontalRadiation),
                ToInvariantString(dataRecord.ExtraterrestrialDirectNormalRadiation),
                ToInvariantString(dataRecord.HorizontalInfraredRadiationIntensity),
                ToInvariantString(dataRecord.GlobalHorizontalRadiation),
                ToInvariantString(dataRecord.DirectNormalRadiation),
                ToInvariantString(dataRecord.DiffuseHorizontalRadiation),
                ToInvariantString(dataRecord.GlobalHorizontalIlluminance),
                ToInvariantString(dataRecord.DirectNormalIlluminance),
                ToInvariantString(dataRecord.DiffuseHorizontalIlluminance),
                ToInvariantString(dataRecord.ZenithLuminance),
                ToInvariantString(dataRecord.WindDirection),
                ToInvariantString(dataRecord.WindSpeed),
                dataRecord.TotalSkyCover.ToString(CultureInfo.InvariantCulture),
                dataRecord.OpaqueSkyCover.ToString(CultureInfo.InvariantCulture),
                ToInvariantString(dataRecord.Visibility),
                ToInvariantString(dataRecord.CeilingHeight),
                dataRecord.PresentWeatherObservation.ToString(CultureInfo.InvariantCulture),
                dataRecord.PresentWeatherCodes ?? string.Empty,
                ToInvariantString(dataRecord.PrecipitableWater),
                ToInvariantString(dataRecord.AerosolOpticalDepth),
                ToInvariantString(dataRecord.SnowDepth),
                dataRecord.DaysSinceLastSnowfall.ToString(CultureInfo.InvariantCulture),
                ToInvariantString(dataRecord.Albedo),
                ToInvariantString(dataRecord.LiquidPrecipitationDepth),
                ToInvariantString(dataRecord.LiquidPrecipitationQuantity),
            ];

            return string.Join(",", values);
        }
    }
}