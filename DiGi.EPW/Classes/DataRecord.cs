using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a single hourly weather data record of an EPW file.
    /// </summary>
    public class DataRecord : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Year))]
        private readonly int year = 0;

        [JsonInclude, JsonPropertyName(nameof(Month))]
        private readonly int month = 0;

        [JsonInclude, JsonPropertyName(nameof(Day))]
        private readonly int day = 0;

        [JsonInclude, JsonPropertyName(nameof(Hour))]
        private readonly int hour = 0;

        [JsonInclude, JsonPropertyName(nameof(Minute))]
        private readonly int minute = 0;

        [JsonInclude, JsonPropertyName(nameof(DataSourceAndUncertaintyFlags))]
        private readonly string? dataSourceAndUncertaintyFlags = null;

        [JsonInclude, JsonPropertyName(nameof(DryBulbTemperature))]
        private readonly double dryBulbTemperature = 0;

        [JsonInclude, JsonPropertyName(nameof(DewPointTemperature))]
        private readonly double dewPointTemperature = 0;

        [JsonInclude, JsonPropertyName(nameof(RelativeHumidity))]
        private readonly double relativeHumidity = 0;

        [JsonInclude, JsonPropertyName(nameof(AtmosphericStationPressure))]
        private readonly double atmosphericStationPressure = 0;

        [JsonInclude, JsonPropertyName(nameof(ExtraterrestrialHorizontalRadiation))]
        private readonly double extraterrestrialHorizontalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(ExtraterrestrialDirectNormalRadiation))]
        private readonly double extraterrestrialDirectNormalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(HorizontalInfraredRadiationIntensity))]
        private readonly double horizontalInfraredRadiationIntensity = 0;

        [JsonInclude, JsonPropertyName(nameof(GlobalHorizontalRadiation))]
        private readonly double globalHorizontalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(DirectNormalRadiation))]
        private readonly double directNormalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(DiffuseHorizontalRadiation))]
        private readonly double diffuseHorizontalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(GlobalHorizontalIlluminance))]
        private readonly double globalHorizontalIlluminance = 0;

        [JsonInclude, JsonPropertyName(nameof(DirectNormalIlluminance))]
        private readonly double directNormalIlluminance = 0;

        [JsonInclude, JsonPropertyName(nameof(DiffuseHorizontalIlluminance))]
        private readonly double diffuseHorizontalIlluminance = 0;

        [JsonInclude, JsonPropertyName(nameof(ZenithLuminance))]
        private readonly double zenithLuminance = 0;

        [JsonInclude, JsonPropertyName(nameof(WindDirection))]
        private readonly double windDirection = 0;

        [JsonInclude, JsonPropertyName(nameof(WindSpeed))]
        private readonly double windSpeed = 0;

        [JsonInclude, JsonPropertyName(nameof(TotalSkyCover))]
        private readonly int totalSkyCover = 0;

        [JsonInclude, JsonPropertyName(nameof(OpaqueSkyCover))]
        private readonly int opaqueSkyCover = 0;

        [JsonInclude, JsonPropertyName(nameof(Visibility))]
        private readonly double visibility = 0;

        [JsonInclude, JsonPropertyName(nameof(CeilingHeight))]
        private readonly double ceilingHeight = 0;

        [JsonInclude, JsonPropertyName(nameof(PresentWeatherObservation))]
        private readonly int presentWeatherObservation = 0;

        [JsonInclude, JsonPropertyName(nameof(PresentWeatherCodes))]
        private readonly string? presentWeatherCodes = null;

        [JsonInclude, JsonPropertyName(nameof(PrecipitableWater))]
        private readonly double precipitableWater = 0;

        [JsonInclude, JsonPropertyName(nameof(AerosolOpticalDepth))]
        private readonly double aerosolOpticalDepth = 0;

        [JsonInclude, JsonPropertyName(nameof(SnowDepth))]
        private readonly double snowDepth = 0;

        [JsonInclude, JsonPropertyName(nameof(DaysSinceLastSnowfall))]
        private readonly int daysSinceLastSnowfall = 0;

        [JsonInclude, JsonPropertyName(nameof(Albedo))]
        private readonly double albedo = 0;

        [JsonInclude, JsonPropertyName(nameof(LiquidPrecipitationDepth))]
        private readonly double liquidPrecipitationDepth = 0;

        [JsonInclude, JsonPropertyName(nameof(LiquidPrecipitationQuantity))]
        private readonly double liquidPrecipitationQuantity = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRecord"/> class.
        /// </summary>
        /// <param name="year">The year of the record.</param>
        /// <param name="month">The month of the record.</param>
        /// <param name="day">The day of the record.</param>
        /// <param name="hour">The hour of the record.</param>
        /// <param name="minute">The minute of the record.</param>
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
        public DataRecord(int year, int month, int day, int hour, int minute, string? dataSourceAndUncertaintyFlags, double dryBulbTemperature, double dewPointTemperature, double relativeHumidity, double atmosphericStationPressure, double extraterrestrialHorizontalRadiation, double extraterrestrialDirectNormalRadiation, double horizontalInfraredRadiationIntensity, double globalHorizontalRadiation, double directNormalRadiation, double diffuseHorizontalRadiation, double globalHorizontalIlluminance, double directNormalIlluminance, double diffuseHorizontalIlluminance, double zenithLuminance, double windDirection, double windSpeed, int totalSkyCover, int opaqueSkyCover, double visibility, double ceilingHeight, int presentWeatherObservation, string? presentWeatherCodes, double precipitableWater, double aerosolOpticalDepth, double snowDepth, int daysSinceLastSnowfall, double albedo, double liquidPrecipitationDepth, double liquidPrecipitationQuantity)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.dataSourceAndUncertaintyFlags = dataSourceAndUncertaintyFlags;
            this.dryBulbTemperature = dryBulbTemperature;
            this.dewPointTemperature = dewPointTemperature;
            this.relativeHumidity = relativeHumidity;
            this.atmosphericStationPressure = atmosphericStationPressure;
            this.extraterrestrialHorizontalRadiation = extraterrestrialHorizontalRadiation;
            this.extraterrestrialDirectNormalRadiation = extraterrestrialDirectNormalRadiation;
            this.horizontalInfraredRadiationIntensity = horizontalInfraredRadiationIntensity;
            this.globalHorizontalRadiation = globalHorizontalRadiation;
            this.directNormalRadiation = directNormalRadiation;
            this.diffuseHorizontalRadiation = diffuseHorizontalRadiation;
            this.globalHorizontalIlluminance = globalHorizontalIlluminance;
            this.directNormalIlluminance = directNormalIlluminance;
            this.diffuseHorizontalIlluminance = diffuseHorizontalIlluminance;
            this.zenithLuminance = zenithLuminance;
            this.windDirection = windDirection;
            this.windSpeed = windSpeed;
            this.totalSkyCover = totalSkyCover;
            this.opaqueSkyCover = opaqueSkyCover;
            this.visibility = visibility;
            this.ceilingHeight = ceilingHeight;
            this.presentWeatherObservation = presentWeatherObservation;
            this.presentWeatherCodes = presentWeatherCodes;
            this.precipitableWater = precipitableWater;
            this.aerosolOpticalDepth = aerosolOpticalDepth;
            this.snowDepth = snowDepth;
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
                year = dataRecord.year;
                month = dataRecord.month;
                day = dataRecord.day;
                hour = dataRecord.hour;
                minute = dataRecord.minute;
                dataSourceAndUncertaintyFlags = dataRecord.dataSourceAndUncertaintyFlags;
                dryBulbTemperature = dataRecord.dryBulbTemperature;
                dewPointTemperature = dataRecord.dewPointTemperature;
                relativeHumidity = dataRecord.relativeHumidity;
                atmosphericStationPressure = dataRecord.atmosphericStationPressure;
                extraterrestrialHorizontalRadiation = dataRecord.extraterrestrialHorizontalRadiation;
                extraterrestrialDirectNormalRadiation = dataRecord.extraterrestrialDirectNormalRadiation;
                horizontalInfraredRadiationIntensity = dataRecord.horizontalInfraredRadiationIntensity;
                globalHorizontalRadiation = dataRecord.globalHorizontalRadiation;
                directNormalRadiation = dataRecord.directNormalRadiation;
                diffuseHorizontalRadiation = dataRecord.diffuseHorizontalRadiation;
                globalHorizontalIlluminance = dataRecord.globalHorizontalIlluminance;
                directNormalIlluminance = dataRecord.directNormalIlluminance;
                diffuseHorizontalIlluminance = dataRecord.diffuseHorizontalIlluminance;
                zenithLuminance = dataRecord.zenithLuminance;
                windDirection = dataRecord.windDirection;
                windSpeed = dataRecord.windSpeed;
                totalSkyCover = dataRecord.totalSkyCover;
                opaqueSkyCover = dataRecord.opaqueSkyCover;
                visibility = dataRecord.visibility;
                ceilingHeight = dataRecord.ceilingHeight;
                presentWeatherObservation = dataRecord.presentWeatherObservation;
                presentWeatherCodes = dataRecord.presentWeatherCodes;
                precipitableWater = dataRecord.precipitableWater;
                aerosolOpticalDepth = dataRecord.aerosolOpticalDepth;
                snowDepth = dataRecord.snowDepth;
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
        /// Gets the year of the record.
        /// </summary>
        [JsonIgnore]
        public int Year
        {
            get
            {
                return year;
            }
        }

        /// <summary>
        /// Gets the month of the record.
        /// </summary>
        [JsonIgnore]
        public int Month
        {
            get
            {
                return month;
            }
        }

        /// <summary>
        /// Gets the day of the record.
        /// </summary>
        [JsonIgnore]
        public int Day
        {
            get
            {
                return day;
            }
        }

        /// <summary>
        /// Gets the hour of the record.
        /// </summary>
        [JsonIgnore]
        public int Hour
        {
            get
            {
                return hour;
            }
        }

        /// <summary>
        /// Gets the minute of the record.
        /// </summary>
        [JsonIgnore]
        public int Minute
        {
            get
            {
                return minute;
            }
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
        /// Gets the dry bulb temperature, in degrees Celsius.
        /// </summary>
        [JsonIgnore]
        public double DryBulbTemperature
        {
            get
            {
                return dryBulbTemperature;
            }
        }

        /// <summary>
        /// Gets the dew point temperature, in degrees Celsius.
        /// </summary>
        [JsonIgnore]
        public double DewPointTemperature
        {
            get
            {
                return dewPointTemperature;
            }
        }

        /// <summary>
        /// Gets the relative humidity, in percent.
        /// </summary>
        [JsonIgnore]
        public double RelativeHumidity
        {
            get
            {
                return relativeHumidity;
            }
        }

        /// <summary>
        /// Gets the atmospheric station pressure, in Pascals.
        /// </summary>
        [JsonIgnore]
        public double AtmosphericStationPressure
        {
            get
            {
                return atmosphericStationPressure;
            }
        }

        /// <summary>
        /// Gets the extraterrestrial horizontal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public double ExtraterrestrialHorizontalRadiation
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
        public double ExtraterrestrialDirectNormalRadiation
        {
            get
            {
                return extraterrestrialDirectNormalRadiation;
            }
        }

        /// <summary>
        /// Gets the horizontal infrared radiation intensity, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public double HorizontalInfraredRadiationIntensity
        {
            get
            {
                return horizontalInfraredRadiationIntensity;
            }
        }

        /// <summary>
        /// Gets the global horizontal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public double GlobalHorizontalRadiation
        {
            get
            {
                return globalHorizontalRadiation;
            }
        }

        /// <summary>
        /// Gets the direct normal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public double DirectNormalRadiation
        {
            get
            {
                return directNormalRadiation;
            }
        }

        /// <summary>
        /// Gets the diffuse horizontal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public double DiffuseHorizontalRadiation
        {
            get
            {
                return diffuseHorizontalRadiation;
            }
        }

        /// <summary>
        /// Gets the global horizontal illuminance, in lux.
        /// </summary>
        [JsonIgnore]
        public double GlobalHorizontalIlluminance
        {
            get
            {
                return globalHorizontalIlluminance;
            }
        }

        /// <summary>
        /// Gets the direct normal illuminance, in lux.
        /// </summary>
        [JsonIgnore]
        public double DirectNormalIlluminance
        {
            get
            {
                return directNormalIlluminance;
            }
        }

        /// <summary>
        /// Gets the diffuse horizontal illuminance, in lux.
        /// </summary>
        [JsonIgnore]
        public double DiffuseHorizontalIlluminance
        {
            get
            {
                return diffuseHorizontalIlluminance;
            }
        }

        /// <summary>
        /// Gets the zenith luminance, in Cd/m2.
        /// </summary>
        [JsonIgnore]
        public double ZenithLuminance
        {
            get
            {
                return zenithLuminance;
            }
        }

        /// <summary>
        /// Gets the wind direction, in degrees.
        /// </summary>
        [JsonIgnore]
        public double WindDirection
        {
            get
            {
                return windDirection;
            }
        }

        /// <summary>
        /// Gets the wind speed, in m/s.
        /// </summary>
        [JsonIgnore]
        public double WindSpeed
        {
            get
            {
                return windSpeed;
            }
        }

        /// <summary>
        /// Gets the total sky cover, in tenths.
        /// </summary>
        [JsonIgnore]
        public int TotalSkyCover
        {
            get
            {
                return totalSkyCover;
            }
        }

        /// <summary>
        /// Gets the opaque sky cover, in tenths.
        /// </summary>
        [JsonIgnore]
        public int OpaqueSkyCover
        {
            get
            {
                return opaqueSkyCover;
            }
        }

        /// <summary>
        /// Gets the visibility, in km.
        /// </summary>
        [JsonIgnore]
        public double Visibility
        {
            get
            {
                return visibility;
            }
        }

        /// <summary>
        /// Gets the ceiling height, in m.
        /// </summary>
        [JsonIgnore]
        public double CeilingHeight
        {
            get
            {
                return ceilingHeight;
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
        public double PrecipitableWater
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
        public double AerosolOpticalDepth
        {
            get
            {
                return aerosolOpticalDepth;
            }
        }

        /// <summary>
        /// Gets the snow depth, in cm.
        /// </summary>
        [JsonIgnore]
        public double SnowDepth
        {
            get
            {
                return snowDepth;
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
        public double Albedo
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
        public double LiquidPrecipitationDepth
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
        public double LiquidPrecipitationQuantity
        {
            get
            {
                return liquidPrecipitationQuantity;
            }
        }
    }
}