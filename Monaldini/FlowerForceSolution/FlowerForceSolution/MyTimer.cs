namespace FlowerForce
{
    /// <summary>
    /// Represents a generic <see cref="MyTimer"/> implementation.
    /// </summary>
    public class MyTimer : ITimer
    {
        private int _timerCyclesCount;
        private int _nCycles;

        /// <summary>
        /// </summary>
        /// <param name="nCycles">indicates every how many game loop cycles an action must be performed</param>
        public MyTimer(int nCycles)
        {
            NCycles = nCycles;
        }

        /// <inheritdoc />
        public int NCycles
        {
            private get => _nCycles;

            set
            {
                VerifyNCycles(value);
                if (_timerCyclesCount >= value)
                {
                    _timerCyclesCount = value - 1;
                }
                _nCycles = value;
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
            if (nCycles <= 0)
            {
                throw new ArgumentException("Timer must be set to a positive integer!");
            }
        }
    }
}
