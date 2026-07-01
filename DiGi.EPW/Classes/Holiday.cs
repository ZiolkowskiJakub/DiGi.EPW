using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a single holiday entry of the HOLIDAYS/DAYLIGHT SAVINGS header record of an EPW file.
    /// </summary>
    public class Holiday : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name = null;

        [JsonInclude, JsonPropertyName(nameof(Date))]
        private readonly string? date = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Holiday"/> class.
        /// </summary>
        /// <param name="name">The name of the holiday.</param>
        /// <param name="date">The date of the holiday.</param>
        public Holiday(string? name, string? date)
        {
            this.name = name;
            this.date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Holiday"/> class by copying an existing instance.
        /// </summary>
        /// <param name="holiday">The source holiday to copy from.</param>
        public Holiday(Holiday? holiday)
            : base(holiday)
        {
            if (holiday != null)
            {
                name = holiday.name;
                date = holiday.date;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Holiday"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing holiday data.</param>
        public Holiday(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the holiday.
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
        /// Gets the date of the holiday.
        /// </summary>
        [JsonIgnore]
        public string? Date
        {
            get
            {
                return date;
            }
        }
    }
}