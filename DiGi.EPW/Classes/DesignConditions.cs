using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents the DESIGN CONDITIONS header record of an EPW file.
    /// </summary>
    public class DesignConditions : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(NumberOfDesignConditions))]
        private readonly int numberOfDesignConditions = 0;

        [JsonInclude, JsonPropertyName(nameof(Source))]
        private readonly string? source = null;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name = null;

        [JsonInclude, JsonPropertyName(nameof(HeatingValues))]
        private readonly IList<double>? heatingValues = null;

        [JsonInclude, JsonPropertyName(nameof(CoolingValues))]
        private readonly IList<double>? coolingValues = null;

        [JsonInclude, JsonPropertyName(nameof(ExtremeValues))]
        private readonly IList<double>? extremeValues = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignConditions"/> class.
        /// </summary>
        /// <param name="numberOfDesignConditions">The number of design conditions contained in the record.</param>
        /// <param name="source">The source of the design condition data.</param>
        /// <param name="name">The design condition name, if specified.</param>
        /// <param name="heatingValues">The heating design condition values, in file order.</param>
        /// <param name="coolingValues">The cooling design condition values, in file order.</param>
        /// <param name="extremeValues">The extreme design condition values, in file order.</param>
        public DesignConditions(int numberOfDesignConditions, string? source, string? name, IList<double>? heatingValues, IList<double>? coolingValues, IList<double>? extremeValues)
        {
            this.numberOfDesignConditions = numberOfDesignConditions;
            this.source = source;
            this.name = name;
            this.heatingValues = heatingValues;
            this.coolingValues = coolingValues;
            this.extremeValues = extremeValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignConditions"/> class by copying an existing instance.
        /// </summary>
        /// <param name="designConditions">The source design conditions to copy from.</param>
        public DesignConditions(DesignConditions? designConditions)
            : base(designConditions)
        {
            if (designConditions != null)
            {
                numberOfDesignConditions = designConditions.numberOfDesignConditions;
                source = designConditions.source;
                name = designConditions.name;
                heatingValues = designConditions.heatingValues == null ? null : new List<double>(designConditions.heatingValues);
                coolingValues = designConditions.coolingValues == null ? null : new List<double>(designConditions.coolingValues);
                extremeValues = designConditions.extremeValues == null ? null : new List<double>(designConditions.extremeValues);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignConditions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing design conditions data.</param>
        public DesignConditions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the number of design conditions contained in the record.
        /// </summary>
        [JsonIgnore]
        public int NumberOfDesignConditions
        {
            get
            {
                return numberOfDesignConditions;
            }
        }

        /// <summary>
        /// Gets the source of the design condition data.
        /// </summary>
        [JsonIgnore]
        public string? Source
        {
            get
            {
                return source;
            }
        }

        /// <summary>
        /// Gets the design condition name, if specified.
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
        /// Gets the heating design condition values, in file order.
        /// </summary>
        [JsonIgnore]
        public IList<double>? HeatingValues
        {
            get
            {
                return heatingValues;
            }
        }

        /// <summary>
        /// Gets the cooling design condition values, in file order.
        /// </summary>
        [JsonIgnore]
        public IList<double>? CoolingValues
        {
            get
            {
                return coolingValues;
            }
        }

        /// <summary>
        /// Gets the extreme design condition values, in file order.
        /// </summary>
        [JsonIgnore]
        public IList<double>? ExtremeValues
        {
            get
            {
                return extremeValues;
            }
        }
    }
}
