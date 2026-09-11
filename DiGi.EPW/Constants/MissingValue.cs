namespace DiGi.EPW.Constants
{
    /// <summary>
    /// Provides constant definitions for the missing-value markers that EPW numeric fields carry instead of a measurement.
    /// </summary>
    public static class MissingValue
    {
        /// <summary>
        /// The value 9999 that marks a missing global horizontal radiation reading in an EPW file.
        /// </summary>
        public const float GlobalHorizontalRadiation = 9999;

        /// <summary>
        /// The value 9999 that marks a missing direct normal radiation reading in an EPW file.
        /// </summary>
        public const float DirectNormalRadiation = 9999;

        /// <summary>
        /// The value 9999 that marks a missing diffuse horizontal radiation reading in an EPW file.
        /// </summary>
        public const float DiffuseHorizontalRadiation = 9999;

        /// <summary>
        /// The value 999 that marks a missing snow depth reading in an EPW file.
        /// </summary>
        public const float SnowDepth = 999;

        /// <summary>
        /// The value 999 that marks a missing albedo reading in an EPW file.
        /// </summary>
        public const float Albedo = 999;
    }
}
