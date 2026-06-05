namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents an EnergyPlus Weather (EPW) file and its associated data.
    /// </summary>
    public class EPWFile
    {
        /// <summary>
        /// Gets the location information associated with this EPW file.
        /// </summary>
        public Location? Location { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EPWFile"/> class.
        /// </summary>
        /// <param name="location">The location associated with the EPW file.</param>
        public EPWFile(Location? location)
        {
            Location = location;
        }
    }
}