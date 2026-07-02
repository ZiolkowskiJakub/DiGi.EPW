using DiGi.Weather.Classes;
using DiGi.EPW.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a single hourly weather data record of an EPW file.
    /// </summary>
    public class DataRecord : WeatherRecord, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(DataSourceAndUncertaintyFlags))]
        private readonly string? dataSourceAndUncertaintyFlags = null;

        [JsonInclude, JsonPropertyName(nameof(ExtraterrestrialHorizontalRadiation))]
        private readonly float extraterrestrialHorizontalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(ExtraterrestrialDirectNormalRadiation))]
        private readonly float extraterrestrialDirectNormalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(ZenithLuminance))]
        private readonly float zenithLuminance = 0;

        [JsonInclude, JsonPropertyName(nameof(Visibility))]
        private readonly float visibility = 0;

        [JsonInclude, JsonPropertyName(nameof(PresentWeatherObservation))]
        private readonly int presentWeatherObservation = 0;

        [JsonInclude, JsonPropertyName(nameof(PresentWeatherCodes))]
        private readonly string? presentWeatherCodes = null;

        [JsonInclude, JsonPropertyName(nameof(PrecipitableWater))]
        private readonly float precipitableWater = 0;

        [JsonInclude, JsonPropertyName(nameof(AerosolOpticalDepth))]
        private readonly float aerosolOpticalDepth = 0;

        [JsonInclude, JsonPropertyName(nameof(DaysSinceLastSnowfall))]
        private readonly int daysSinceLastSnowfall = 0;

        [JsonInclude, JsonPropertyName(nameof(Albedo))]
        private readonly float albedo = 0;

        [JsonInclude, JsonPropertyName(nameof(LiquidPrecipitationDepth))]
        private readonly float liquidPrecipitationDepth = 0;

        [JsonInclude, JsonPropertyName(nameof(LiquidPrecipitationQuantity))]
        private readonly float liquidPrecipitationQuantity = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRecord"/> class.
        /// </summary>
        /// <param name="dateTime">The date and time of the record.</param>
        /// <param name="dataSourceAndUncertaintyFlags">The data source and uncertainty flags string.</param>
        /// <param name="dryBulbTemperature">The dry bulb temperature, in degrees Celsius.</param>
        /// <param name="dewPointTemperature">The dew point temperature, in degrees Celsius.</param>
        /// <param name="relativeHumidity">The relative humidity, in percent.</param>
        /// <param name="atmosphericStationPressure">The atmospheric station pressure, in Pascals.</param>
        /// <param name="extraterrestrialHorizontalRadiation">The extraterrestrial horizontal radiation, in Wh/m2.</param>
        /// <param name="extraterrestrialDirectNormalRadiation">The extraterrestrial direct normal radiation, in Wh/m2.</param>
        /// <param name="horizontalInfraredRadiationIntensity">The horizontal infrared radiation intensity, in Wh/m2.</param>
        /// <param name="globalHorizontalRadiation">The global horizontal radiation, in Wh/m2.</param>
        /// <param name="directNormalRadiation">The direct normal radiation, in Wh/m2.</param>
        /// <param name="diffuseHorizontalRadiation">The diffuse horizontal radiation, in Wh/m2.</param>
        /// <param name="globalHorizontalIlluminance">The global horizontal illuminance, in lux.</param>
        /// <param name="directNormalIlluminance">The direct normal illuminance, in lux.</param>
        /// <param name="diffuseHorizontalIlluminance">The diffuse horizontal illuminance, in lux.</param>
        /// <param name="zenithLuminance">The zenith luminance, in Cd/m2.</param>
        /// <param name="windDirection">The wind direction, in degrees.</param>
        /// <param name="windSpeed">The wind speed, in m/s.</param>
        /// <param name="totalSkyCover">The total sky cover, in tenths.</param>
        /// <param name="opaqueSkyCover">The opaque sky cover, in tenths.</param>
        /// <param name="visibility">The visibility, in km.</param>
        /// <param name="ceilingHeight">The ceiling height, in m.</param>
        /// <param name="presentWeatherObservation">The present weather observation flag.</param>
        /// <param name="presentWeatherCodes">The present weather codes.</param>
        /// <param name="precipitableWater">The precipitable water, in mm.</param>
        /// <param name="aerosolOpticalDepth">The aerosol optical depth, in thousandths.</param>
        /// <param name="snowDepth">The snow depth, in cm.</param>
        /// <param name="daysSinceLastSnowfall">The number of days since the last snowfall.</param>
        /// <param name="albedo">The albedo.</param>
        /// <param name="liquidPrecipitationDepth">The liquid precipitation depth, in mm.</param>
        /// <param name="liquidPrecipitationQuantity">The liquid precipitation quantity, in hours.</param>
        public DataRecord(
            DateTime dateTime,
            string? dataSourceAndUncertaintyFlags,
            float dryBulbTemperature,
            float dewPointTemperature,
            float relativeHumidity,
            float atmosphericStationPressure,
            float extraterrestrialHorizontalRadiation,
            float extraterrestrialDirectNormalRadiation,
            float horizontalInfraredRadiationIntensity,
            float globalHorizontalRadiation,
            float directNormalRadiation,
            float diffuseHorizontalRadiation,
            float globalHorizontalIlluminance,
            float directNormalIlluminance,
            float diffuseHorizontalIlluminance,
            float zenithLuminance,
            float windDirection,
            float windSpeed,
            int totalSkyCover,
            int opaqueSkyCover,
            float visibility,
            float ceilingHeight,
            int presentWeatherObservation,
            string? presentWeatherCodes,
            float precipitableWater,
            float aerosolOpticalDepth,
            float snowDepth,
            int daysSinceLastSnowfall,
            float albedo,
            float liquidPrecipitationDepth,
            float liquidPrecipitationQuantity)
            : base(
                dateTime,
                dataSourceAndUncertaintyFlags,
                dryBulbTemperature,
                dewPointTemperature,
                relativeHumidity,
                atmosphericStationPressure,
                extraterrestrialHorizontalRadiation,
                extraterrestrialDirectNormalRadiation,
                horizontalInfraredRadiationIntensity,
                globalHorizontalRadiation,
                directNormalRadiation,
                diffuseHorizontalRadiation,
                globalHorizontalIlluminance,
                directNormalIlluminance,
                diffuseHorizontalIlluminance,
                zenithLuminance,
                windDirection,
                windSpeed,
                totalSkyCover,
                opaqueSkyCover,
                visibility,
                ceilingHeight,
                presentWeatherObservation,
                presentWeatherCodes,
                precipitableWater,
                aerosolOpticalDepth,
                snowDepth,
                daysSinceLastSnowfall,
                albedo,
                liquidPrecipitationDepth,
                liquidPrecipitationQuantity)
        {
            this.dataSourceAndUncertaintyFlags = dataSourceAndUncertaintyFlags;
            this.extraterrestrialHorizontalRadiation = extraterrestrialHorizontalRadiation;
            this.extraterrestrialDirectNormalRadiation = extraterrestrialDirectNormalRadiation;
            this.zenithLuminance = zenithLuminance;
            this.visibility = visibility;
            this.presentWeatherObservation = presentWeatherObservation;
            this.presentWeatherCodes = presentWeatherCodes;
            this.precipitableWater = precipitableWater;
            this.aerosolOpticalDepth = aerosolOpticalDepth;
            this.daysSinceLastSnowfall = daysSinceLastSnowfall;
            this.albedo = albedo;
            this.liquidPrecipitationDepth = liquidPrecipitationDepth;
            this.liquidPrecipitationQuantity = liquidPrecipitationQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRecord"/> class by copying an existing instance.
        /// </summary>
        /// <param name="dataRecord">The source data record to copy from.</param>
        public DataRecord(DataRecord? dataRecord)
            : base(dataRecord)
        {
            if (dataRecord != null)
            {
                dataSourceAndUncertaintyFlags = dataRecord.dataSourceAndUncertaintyFlags;
                extraterrestrialHorizontalRadiation = dataRecord.extraterrestrialHorizontalRadiation;
                extraterrestrialDirectNormalRadiation = dataRecord.extraterrestrialDirectNormalRadiation;
                zenithLuminance = dataRecord.zenithLuminance;
                visibility = dataRecord.visibility;
                presentWeatherObservation = dataRecord.presentWeatherObservation;
                presentWeatherCodes = dataRecord.presentWeatherCodes;
                precipitableWater = dataRecord.precipitableWater;
                aerosolOpticalDepth = dataRecord.aerosolOpticalDepth;
                daysSinceLastSnowfall = dataRecord.daysSinceLastSnowfall;
                albedo = dataRecord.albedo;
                liquidPrecipitationDepth = dataRecord.liquidPrecipitationDepth;
                liquidPrecipitationQuantity = dataRecord.liquidPrecipitationQuantity;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRecord"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing hourly weather data.</param>
        public DataRecord(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the data source and uncertainty flags string.
        /// </summary>
        [JsonIgnore]
        public string? DataSourceAndUncertaintyFlags
        {
            get
            {
                return dataSourceAndUncertaintyFlags;
            }
        }

        /// <summary>
        /// Gets the extraterrestrial horizontal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public float ExtraterrestrialHorizontalRadiation
        {
            get
            {
                return extraterrestrialHorizontalRadiation;
            }
        }

        /// <summary>
        /// Gets the extraterrestrial direct normal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public float ExtraterrestrialDirectNormalRadiation
        {
            get
            {
                return extraterrestrialDirectNormalRadiation;
            }
        }

        /// <summary>
        /// Gets the zenith luminance, in Cd/m2.
        /// </summary>
        [JsonIgnore]
        public float ZenithLuminance
        {
            get
            {
                return zenithLuminance;
            }
        }

        /// <summary>
        /// Gets the visibility, in km.
        /// </summary>
        [JsonIgnore]
        public float Visibility
        {
            get
            {
                return visibility;
            }
        }

        /// <summary>
        /// Gets the present weather observation flag.
        /// </summary>
        [JsonIgnore]
        public int PresentWeatherObservation
        {
            get
            {
                return presentWeatherObservation;
            }
        }

        /// <summary>
        /// Gets the present weather codes.
        /// </summary>
        [JsonIgnore]
        public string? PresentWeatherCodes
        {
            get
            {
                return presentWeatherCodes;
            }
        }

        /// <summary>
        /// Gets the precipitable water, in mm.
        /// </summary>
        [JsonIgnore]
        public float PrecipitableWater
        {
            get
            {
                return precipitableWater;
            }
        }

        /// <summary>
        /// Gets the aerosol optical depth, in thousandths.
        /// </summary>
        [JsonIgnore]
        public float AerosolOpticalDepth
        {
            get
            {
                return aerosolOpticalDepth;
            }
        }

        /// <summary>
        /// Gets the number of days since the last snowfall.
        /// </summary>
        [JsonIgnore]
        public int DaysSinceLastSnowfall
        {
            get
            {
                return daysSinceLastSnowfall;
            }
        }

        /// <summary>
        /// Gets the albedo.
        /// </summary>
        [JsonIgnore]
        public float Albedo
        {
            get
            {
                return albedo;
            }
        }

        /// <summary>
        /// Gets the liquid precipitation depth, in mm.
        /// </summary>
        [JsonIgnore]
        public float LiquidPrecipitationDepth
        {
            get
            {
                return liquidPrecipitationDepth;
            }
        }

        /// <summary>
        /// Gets the liquid precipitation quantity, in hours.
        /// </summary>
        [JsonIgnore]
        public float LiquidPrecipitationQuantity
        {
            get
            {
                return liquidPrecipitationQuantity;
            }
        }
    }
}