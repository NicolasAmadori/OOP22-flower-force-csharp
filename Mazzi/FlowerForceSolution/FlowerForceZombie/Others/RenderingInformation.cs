
namespace Others
{
    /// <summary>
    /// Utility class to get the rendering information.
    /// </summary>
    public static class RenderingInformation
    {
        /// <summary>
        /// Get the frames per second the game must be set to.
        /// </summary>
        public const int FramesPerSecond = 30;

        /// <summary>
        /// Converts from seconds an entity uses to cross a cell to position
        /// it has to move each frame.
        /// </summary>
        /// <param name="secondsPerCell"> seconds an entity uses to cross a cell </param>
        /// <returns> positions it has to move each frame </returns>
        public static float GetDeltaFromSecondsPerCell(double secondsPerCell)
            => YardInfo.Cell.Width / ConvertSecondsToCycles(secondsPerCell);

        /// <summary>
        /// Convert seconds to number of frames in that time.
        /// </summary>
        /// <param name="seconds"> number of seconds to convert </param>
        /// <returns> number of frames </returns>
        public static int ConvertSecondsToCycles(double seconds) => (int) (seconds * FramesPerSecond);

    }
}
