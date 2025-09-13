namespace DiGi.EPW.Classes
{
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

        public string? City
        {
            get
            {
                return city;
            }
        }

        public string? Country
        {
            get
            {
                return country;
            }
        }

        public double Elevation
        {
            get
            {
                return elevation;
            }
        }

        public double Latitude
        {
            get
            {
                return latitude;
            }
        }

        public double Longitude
        {
            get
            {
                return longitude;
            }
        }

        public string? Region
        {
            get
            {
                return region;
            }
        }
        
        public string? Source
        {
            get
            {
                return source;
            }
        }

        public double TimeZone
        {
            get
            {
                return timeZone;
            }
        }

        public string? WHO
        {
            get
            {
                return wHO;
            }
        }
    }
}
