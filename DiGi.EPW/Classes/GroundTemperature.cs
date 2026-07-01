using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a single depth entry of the GROUND TEMPERATURES header record of an EPW file.
    /// </summary>
    public class GroundTemperature : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Depth))]
        private readonly double depth = 0;

        [JsonInclude, JsonPropertyName(nameof(Conductivity))]
        private readonly double? conductivity = null;

        [JsonInclude, JsonPropertyName(nameof(Density))]
        private readonly double? density = null;

        [JsonInclude, JsonPropertyName(nameof(SpecificHeat))]
        private readonly double? specificHeat = null;

        [JsonInclude, JsonPropertyName(nameof(MonthlyValues))]
        private readonly IList<double>? monthlyValues = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundTemperature"/> class.
        /// </summary>
        /// <param name="depth">The ground depth, in meters.</param>
        /// <param name="conductivity">The soil thermal conductivity, if specified.</param>
        /// <param name="density">The soil density, if specified.</param>
        /// <param name="specificHeat">The soil specific heat, if specified.</param>
        /// <param name="monthlyValues">The twelve monthly ground temperature values.</param>
        public GroundTemperature(double depth, double? conductivity, double? density, double? specificHeat, IList<double>? monthlyValues)
        {
            this.depth = depth;
            this.conductivity = conductivity;
            this.density = density;
            this.specificHeat = specificHeat;
            this.monthlyValues = monthlyValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundTemperature"/> class by copying an existing instance.
        /// </summary>
        /// <param name="groundTemperature">The source ground temperature to copy from.</param>
        public GroundTemperature(GroundTemperature? groundTemperature)
            : base(groundTemperature)
        {
            if (groundTemperature != null)
            {
                depth = groundTemperature.depth;
                conductivity = groundTemperature.conductivity;
                density = groundTemperature.density;
                specificHeat = groundTemperature.specificHeat;
                monthlyValues = groundTemperature.monthlyValues == null ? null : new List<double>(groundTemperature.monthlyValues);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundTemperature"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing ground temperature data.</param>
        public GroundTemperature(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the ground depth, in meters.
        /// </summary>
        [JsonIgnore]
        public double Depth
        {
            get
            {
                return depth;
            }
        }

        /// <summary>
        /// Gets the soil thermal conductivity, if specified.
        /// </summary>
        [JsonIgnore]
        public double? Conductivity
        {
            get
            {
                return conductivity;
            }
        }

        /// <summary>
        /// Gets the soil density, if specified.
        /// </summary>
        [JsonIgnore]
        public double? Density
        {
            get
            {
                return density;
            }
        }

        /// <summary>
        /// Gets the soil specific heat, if specified.
        /// </summary>
        [JsonIgnore]
        public double? SpecificHeat
        {
            get
            {
                return specificHeat;
            }
        }

        /// <summary>
        /// Gets the twelve monthly ground temperature values.
        /// </summary>
        [JsonIgnore]
        public IList<double>? MonthlyValues
        {
            get
            {
                return monthlyValues;
            }
        }
    }
}