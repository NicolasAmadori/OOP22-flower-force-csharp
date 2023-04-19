using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Others;

namespace FlowerForce
{
    /// <summary>
    /// Utility class to get the rendering information.
    /// </summary>
    public static class RenderingInformations
    {
        /// <summary>
        /// Frames per second the game must be set to.
        /// </summary>
        public static int FramesPerSecond 
        {
            get => 30;
        }

        /// <summary>
        /// Converts from seconds an entity uses to cross a cell to position
        /// </summary>
        /// <param name="seconds">seconds an entity uses to cross a cell</param>
        /// <returns>positions it has to move each frame</returns>
        public static double GetDeltaFromSecondsPerCell(double seconds)
            => YardInfo.Cell.Width / ConvertSecondsToCycles(seconds);

        /// <summary>
        /// Convert seconds to number of frames in that time.
        /// </summary>
        /// <param name="seconds">number of seconds to convert</param>
        /// <returns>number of frames</returns>
        public static int ConvertSecondsToCycles(double seconds) => (int) (seconds * FramesPerSecond);

    }
}
