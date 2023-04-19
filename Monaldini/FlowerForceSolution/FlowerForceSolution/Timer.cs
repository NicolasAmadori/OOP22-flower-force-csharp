namespace FlowerForce
{
    /// <summary>
    /// Represents a generic <see cref="Timer"/> implementation.
    /// </summary>
    public class Timer : ITimer
    {
        private int _timerCyclesCount;

        /// <summary>
        /// </summary>
        /// <param name="nCycles">indicates every how many game loop cycles an action must be performed</param>
        public Timer(int nCycles)
        {
            NCycles = nCycles;
        }

        /// <inheritdoc />
        public int NCycles
        {
            private get => NCycles;

            set
            {
                VerifyNCycles(value);
                NCycles = value;
            }
        }

        /// <inheritdoc />
        public bool Ready => _timerCyclesCount == 0;

        /// <inheritdoc />
        public void Reset() => _timerCyclesCount = 0;

        /// <inheritdoc />
        public void UpdateState() => _timerCyclesCount = (_timerCyclesCount + 1 ) % NCycles;

        private static void VerifyNCycles(int nCycles)
        {
            if (nCycles > 0)
            {
                throw new ArgumentException("Timer must be set to a positive integer!");
            }
        }
    }
}
