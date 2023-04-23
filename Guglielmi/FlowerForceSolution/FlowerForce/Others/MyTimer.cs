
namespace Others
{
    /// <summary>
    /// Represents a generic Timer implementation.
    /// </summary>
    public class MyTimer : ITimer
    {
        private int _nCycles;
        private int _timerCyclesCount;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nCycles"> indicates every how many game loop cycles an action must be performed </param>
        public MyTimer(int nCycles)
        {
            VerifyNCycles(nCycles);
            _nCycles = nCycles;
        }

        /// <inheritdoc />
        public bool Ready { get; private set; }

        /// <inheritdoc />
        public void Reset() => _timerCyclesCount = 0;

        /// <inheritdoc />
        public void UpdateState()
        {
            _timerCyclesCount = (_timerCyclesCount + 1) % _nCycles;
            Ready = _timerCyclesCount == 0;
        }

        /// <inheritdoc />
        public void SetNumCycles(int newNCycles)
        {
            VerifyNCycles(newNCycles);
            if (_timerCyclesCount >= newNCycles)
            {
                _timerCyclesCount = newNCycles - 1;
            }
            _nCycles = newNCycles;
        }

        static private void VerifyNCycles(int nCycles)
        {
            if (nCycles <= 0)
            {
                throw new ArgumentException("Timer must be set to a positive integer!");
            }
        }
    }
}
