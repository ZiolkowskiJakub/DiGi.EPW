namespace DiGi.EPW.Classes
{
    public class Location
    {
        private string city = null;
        private string country = null;
        private double elevation = 0;
        private double latitude = 0;
        private double longitude = 0;
        private string region = null;
        private string source = null;
        private double timeZone = 0;
        private string wHO = null;
        
        public Location(string city, string region, string country, string source, string wHO, double latitude, double longitude, double timeZone, double elevation)
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

        public string City
        {
            get
            {
                return city;
            }
        }

        public string Country
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

        public string Region
        {
            get
            {
                return region;
            }
        }
        
        public string Source
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

        public string WHO
        {
            get
            {
                return wHO;
            }
        }
    }
}
