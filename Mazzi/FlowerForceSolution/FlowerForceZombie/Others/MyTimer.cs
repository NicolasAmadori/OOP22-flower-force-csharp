
namespace Others
{
    /// <summary>
    /// Implementation of <see cref="ITimer"/>.
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
            _timerCyclesCount = 0;
            Ready = false;
        }

        /// <inheritdoc />
        public bool Ready { get; private set; }

        /// <inheritdoc />
        public void Reset() => _timerCyclesCount = 0;

        /// <inheritdoc />
        public void SetNumCycles(int newNumCycles)
        {
            VerifyNCycles(newNumCycles);
            if (_timerCyclesCount >= newNumCycles)
            {
                _timerCyclesCount = newNumCycles - 1;
            }
            _nCycles = newNumCycles;
        }

        /// <inheritdoc />
        public void UpdateState()
        {
            _timerCyclesCount = (_timerCyclesCount + 1) % _nCycles;
            Ready = _timerCyclesCount == 0;
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
