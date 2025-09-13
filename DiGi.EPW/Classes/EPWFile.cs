namespace DiGi.EPW.Classes
{
    public class EPWFile
    {
        public Location? Location { get; }

        public EPWFile(Location? location)
        {
            Location = location;
        }
    }
}
