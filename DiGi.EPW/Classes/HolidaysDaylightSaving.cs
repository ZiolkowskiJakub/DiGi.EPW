using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents the HOLIDAYS/DAYLIGHT SAVINGS header record of an EPW file.
    /// </summary>
    public class HolidaysDaylightSaving : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(LeapYearObserved))]
        private readonly bool leapYearObserved = false;

        [JsonInclude, JsonPropertyName(nameof(DaylightSavingStartDate))]
        private readonly string? daylightSavingStartDate = null;

        [JsonInclude, JsonPropertyName(nameof(DaylightSavingEndDate))]
        private readonly string? daylightSavingEndDate = null;

        [JsonInclude, JsonPropertyName(nameof(Holidays))]
        private readonly IList<Holiday>? holidays = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidaysDaylightSaving"/> class.
        /// </summary>
        /// <param name="leapYearObserved">Indicates whether the leap year is observed.</param>
        /// <param name="daylightSavingStartDate">The daylight saving start date.</param>
        /// <param name="daylightSavingEndDate">The daylight saving end date.</param>
        /// <param name="holidays">The list of holidays defined in the file.</param>
        public HolidaysDaylightSaving(bool leapYearObserved, string? daylightSavingStartDate, string? daylightSavingEndDate, IList<Holiday>? holidays)
        {
            this.leapYearObserved = leapYearObserved;
            this.daylightSavingStartDate = daylightSavingStartDate;
            this.daylightSavingEndDate = daylightSavingEndDate;
            this.holidays = holidays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidaysDaylightSaving"/> class by copying an existing instance.
        /// </summary>
        /// <param name="holidaysDaylightSaving">The source holidays/daylight saving record to copy from.</param>
        public HolidaysDaylightSaving(HolidaysDaylightSaving? holidaysDaylightSaving)
            : base(holidaysDaylightSaving)
        {
            if (holidaysDaylightSaving != null)
            {
                leapYearObserved = holidaysDaylightSaving.leapYearObserved;
                daylightSavingStartDate = holidaysDaylightSaving.daylightSavingStartDate;
                daylightSavingEndDate = holidaysDaylightSaving.daylightSavingEndDate;

                if (holidaysDaylightSaving.holidays != null)
                {
                    holidays = [];
                    foreach (Holiday holiday in holidaysDaylightSaving.holidays)
                    {
                        if (Core.Query.Clone(holiday) is Holiday holiday_Temp)
                        {
                            holidays.Add(holiday_Temp);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidaysDaylightSaving"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing holidays/daylight saving data.</param>
        public HolidaysDaylightSaving(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the leap year is observed.
        /// </summary>
        [JsonIgnore]
        public bool LeapYearObserved
        {
            get
            {
                return leapYearObserved;
            }
        }

        /// <summary>
        /// Gets the daylight saving start date.
        /// </summary>
        [JsonIgnore]
        public string? DaylightSavingStartDate
        {
            get
            {
                return daylightSavingStartDate;
            }
        }

        /// <summary>
        /// Gets the daylight saving end date.
        /// </summary>
        [JsonIgnore]
        public string? DaylightSavingEndDate
        {
            get
            {
                return daylightSavingEndDate;
            }
        }

        /// <summary>
        /// Gets the list of holidays defined in the file.
        /// </summary>
        [JsonIgnore]
        public IList<Holiday>? Holidays
        {
            get
            {
                return holidays;
            }
        }
    }
}
