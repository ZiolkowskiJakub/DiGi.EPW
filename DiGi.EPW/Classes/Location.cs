namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents a geographical location including coordinates, elevation, and administrative details.
    /// </summary>
    public class Location
    {
        private readonly string? city = null;
        private readonly string? country = null;
        private readonly double elevation = 0;
        private readonly double latitude = 0;
        private readonly double longitude = 0;
        private readonly string? region = null;
        private readonly string? source = null;
        private readonly double timeZone = 0;
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
        /// Gets the name of the city.
        /// </summary>
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
        public string? WHO
        {
            get
            {
                return wHO;
            }
        }
    }
}