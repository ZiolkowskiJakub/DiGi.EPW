using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a geographical location including coordinates, elevation, and administrative details.
    /// </summary>
    public class Location : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(City))]
        private readonly string? city = null;

        [JsonInclude, JsonPropertyName(nameof(Country))]
        private readonly string? country = null;

        [JsonInclude, JsonPropertyName(nameof(Elevation))]
        private readonly double elevation = 0;

        [JsonInclude, JsonPropertyName(nameof(Latitude))]
        private readonly double latitude = 0;

        [JsonInclude, JsonPropertyName(nameof(Longitude))]
        private readonly double longitude = 0;

        [JsonInclude, JsonPropertyName(nameof(Region))]
        private readonly string? region = null;

        [JsonInclude, JsonPropertyName(nameof(Source))]
        private readonly string? source = null;

        [JsonInclude, JsonPropertyName(nameof(TimeZone))]
        private readonly double timeZone = 0;

        [JsonInclude, JsonPropertyName(nameof(WHO))]
        private readonly string? wHO = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="city">The name of the city.</param>
        /// <param name="region">The region or administrative area.</param>
        /// <param name="country">The name of the country.</param>
        /// <param name="source">The source of the location data.</param>
        /// <param name="wHO">The World Health Organization designation.</param>
        /// <param name="latitude">The latitude coordinate.</param>
        /// <param name="longitude">The longitude coordinate.</param>
        /// <param name="timeZone">The time zone offset.</param>
        /// <param name="elevation">The elevation above sea level.</param>
        public Location(string? city, string? region, string? country, string? source, string? wHO, double latitude, double longitude, double timeZone, double elevation)
        {
            this.city = city;
            this.region = region;
            this.country = country;
            this.source = source;
            this.wHO = wHO;
            this.latitude = latitude;
            this.longitude = longitude;
            this.timeZone = timeZone;
            this.elevation = elevation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class by copying an existing instance.
        /// </summary>
        /// <param name="location">The source location to copy from.</param>
        public Location(Location? location)
            : base(location)
        {
            if (location != null)
            {
                city = location.city;
                region = location.region;
                country = location.country;
                source = location.source;
                wHO = location.wHO;
                latitude = location.latitude;
                longitude = location.longitude;
                timeZone = location.timeZone;
                elevation = location.elevation;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing location data.</param>
        public Location(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the city.
        /// </summary>
        [JsonIgnore]
        public string? City
        {
            get
            {
                return city;
            }
        }

        /// <summary>
        /// Gets the name of the country.
        /// </summary>
        [JsonIgnore]
        public string? Country
        {
            get
            {
                return country;
            }
        }

        /// <summary>
        /// Gets the elevation of the location.
        /// </summary>
        [JsonIgnore]
        public double Elevation
        {
            get
            {
                return elevation;
            }
        }

        /// <summary>
        /// Gets the latitude coordinate of the location.
        /// </summary>
        [JsonIgnore]
        public double Latitude
        {
            get
            {
                return latitude;
            }
        }

        /// <summary>
        /// Gets the longitude coordinate of the location.
        /// </summary>
        [JsonIgnore]
        public double Longitude
        {
            get
            {
                return longitude;
            }
        }

        /// <summary>
        /// Gets the region or administrative area of the location.
        /// </summary>
        [JsonIgnore]
        public string? Region
        {
            get
            {
                return region;
            }
        }

        /// <summary>
        /// Gets the source from which the location data was retrieved.
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
        /// Gets the time zone offset for the location.
        /// </summary>
        [JsonIgnore]
        public double TimeZone
        {
            get
            {
                return timeZone;
            }
        }

        /// <summary>
        /// Gets the World Health Organization (WHO) designation for the location.
        /// </summary>
        [JsonIgnore]
        public string? WHO
        {
            get
            {
                return wHO;
            }
        }
    }
}
