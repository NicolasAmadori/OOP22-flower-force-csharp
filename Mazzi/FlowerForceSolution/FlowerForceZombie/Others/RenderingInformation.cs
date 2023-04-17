
namespace Others
{
    public static class RenderingInformation
    {
        public const int FramesPerSecond = 30;

        //TODO: use YardInfo
        public static double GetDeltaFromSecondsPerCell(double secondsPerCell)
            => YardInfo.Cell.Width / ConvertSecondsToCycles(secondsPerCell);

        public static int ConvertSecondsToCycles(double seconds) => (int)(seconds * FramesPerSecond);

    }
}
