using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a single period entry of the TYPICAL/EXTREME PERIODS header record of an EPW file.
    /// </summary>
    public class TypicalExtremePeriod : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name = null;

        [JsonInclude, JsonPropertyName(nameof(PeriodType))]
        private readonly string? periodType = null;

        [JsonInclude, JsonPropertyName(nameof(StartDate))]
        private readonly string? startDate = null;

        [JsonInclude, JsonPropertyName(nameof(EndDate))]
        private readonly string? endDate = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypicalExtremePeriod"/> class.
        /// </summary>
        /// <param name="name">The name of the typical or extreme period.</param>
        /// <param name="periodType">The type of the period, e.g. Typical or Extreme.</param>
        /// <param name="startDate">The start date of the period.</param>
        /// <param name="endDate">The end date of the period.</param>
        public TypicalExtremePeriod(string? name, string? periodType, string? startDate, string? endDate)
        {
            this.name = name;
            this.periodType = periodType;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypicalExtremePeriod"/> class by copying an existing instance.
        /// </summary>
        /// <param name="typicalExtremePeriod">The source typical/extreme period to copy from.</param>
        public TypicalExtremePeriod(TypicalExtremePeriod? typicalExtremePeriod)
            : base(typicalExtremePeriod)
        {
            if (typicalExtremePeriod != null)
            {
                name = typicalExtremePeriod.name;
                periodType = typicalExtremePeriod.periodType;
                startDate = typicalExtremePeriod.startDate;
                endDate = typicalExtremePeriod.endDate;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypicalExtremePeriod"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing typical/extreme period data.</param>
        public TypicalExtremePeriod(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the typical or extreme period.
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
        /// Gets the type of the period, e.g. Typical or Extreme.
        /// </summary>
        [JsonIgnore]
        public string? PeriodType
        {
            get
            {
                return periodType;
            }
        }

        /// <summary>
        /// Gets the start date of the period.
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
        /// Gets the end date of the period.
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
