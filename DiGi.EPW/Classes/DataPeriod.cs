using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a single period entry of the DATA PERIODS header record of an EPW file.
    /// </summary>
    public class DataPeriod : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name = null;

        [JsonInclude, JsonPropertyName(nameof(StartDayOfWeek))]
        private readonly string? startDayOfWeek = null;

        [JsonInclude, JsonPropertyName(nameof(StartDate))]
        private readonly string? startDate = null;

        [JsonInclude, JsonPropertyName(nameof(EndDate))]
        private readonly string? endDate = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPeriod"/> class.
        /// </summary>
        /// <param name="name">The name of the data period.</param>
        /// <param name="startDayOfWeek">The day of week on which the data period starts.</param>
        /// <param name="startDate">The start date of the data period.</param>
        /// <param name="endDate">The end date of the data period.</param>
        public DataPeriod(string? name, string? startDayOfWeek, string? startDate, string? endDate)
        {
            this.name = name;
            this.startDayOfWeek = startDayOfWeek;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPeriod"/> class by copying an existing instance.
        /// </summary>
        /// <param name="dataPeriod">The source data period to copy from.</param>
        public DataPeriod(DataPeriod? dataPeriod)
            : base(dataPeriod)
        {
            if (dataPeriod != null)
            {
                name = dataPeriod.name;
                startDayOfWeek = dataPeriod.startDayOfWeek;
                startDate = dataPeriod.startDate;
                endDate = dataPeriod.endDate;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPeriod"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing data period data.</param>
        public DataPeriod(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the data period.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the day of week on which the data period starts.
        /// </summary>
        [JsonIgnore]
        public string? StartDayOfWeek
        {
            get
            {
                return startDayOfWeek;
            }
        }

        /// <summary>
        /// Gets the start date of the data period.
        /// </summary>
        [JsonIgnore]
        public string? StartDate
        {
            get
            {
                return startDate;
            }
        }

        /// <summary>
        /// Gets the end date of the data period.
        /// </summary>
        [JsonIgnore]
        public string? EndDate
        {
            get
            {
                return endDate;
            }
        }
    }
}