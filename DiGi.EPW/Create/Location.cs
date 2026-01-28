using DiGi.EPW.Classes;

namespace DiGi.EPW
{
    public static partial class Create
    {
        public static Location? Location(string[]? lines, int index, out int index_Next)
        {
            index_Next = -1;

            if (lines == null || lines.Length == 0)
            {
                return null;
            }

            if (index < 0 || index > lines.Length)
            {
                return null;
            }

            string line = lines[index].Trim();

            string[] values = line.Split(',');

            string? city = null;
            string? country = null;
            double elevation = 0;
            double latitude = 0;
            double longitude = 0;
            string? source = null;
            double timeZone = 0;
            string? wHO = null;
            string? region = null;

            if (values.Length > 1)
            {
                city = values[1];

                if (values.Length > 2)
                {
                    region = values[2];

                    if (values.Length > 3)
                    {
                        country = values[3];

                        if (values.Length > 4)
                        {
                            source = values[4];

                            if (values.Length > 5)
                            {
                                wHO = values[5];

                                if (values.Length > 6)
                                {
                                    if (double.TryParse(values[6], out double latitude_Temp))
                                    {
                                        latitude = latitude_Temp;
                                    }

                                    if (values.Length > 7)
                                    {
                                        if (double.TryParse(values[7], out double longitude_Temp))
                                        {
                                            longitude = longitude_Temp;
                                        }

                                        if (values.Length > 8)
                                        {
                                            if (double.TryParse(values[8], out double timeZone_Temp))
                                            {
                                                timeZone = timeZone_Temp;
                                            }

                                            if (values.Length > 9)
                                            {
                                                if (double.TryParse(values[9], out double elevation_Temp))
                                                {
                                                    elevation = elevation_Temp;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            index_Next = index++;

            return new Location(city, region, country, source, wHO, latitude, longitude, timeZone, elevation);
        }
    }
}