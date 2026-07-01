using DiGi.EPW.Classes;
using System;

namespace DiGi.EPW
{
    /// <summary>
    /// Provides extension methods for querying EPW-related objects.
    /// </summary>
    public static partial class Query
    {
        /// <summary>
        /// Generates the name of the EPW file based on its location properties, omitting the file extension.
        /// </summary>
        /// <param name="ePWFile">The EPW file to generate the name for.</param>
        /// <returns>The generated name without the file extension.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided EPW file is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the EPW file does not have a valid location.</exception>
        public static string Name(this EPWFile ePWFile)
        {
            if (ePWFile is null)
            {
                throw new ArgumentNullException(nameof(ePWFile));
            }

            if (ePWFile.Location is not Location location)
            {
                throw new ArgumentException("EPWFile must have a valid Location to generate a name.");
            }

            string country = location.Country ?? string.Empty;
            string city = location.City ?? string.Empty;
            string who = location.WHO ?? string.Empty;
            string source = location.Source ?? string.Empty;

            return $"{country}_{city}.{who}_{source}";
        }
    }
}