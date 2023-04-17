
namespace Others
{
    public static class RenderingInformation
    {
        public const int FramesPerSecond = 30;

        public static float GetDeltaFromSecondsPerCell(double secondsPerCell)
            => YardInfo.Cell.Width / ConvertSecondsToCycles(secondsPerCell);

        public static int ConvertSecondsToCycles(double seconds) => (int) (seconds * FramesPerSecond);

    }
}
