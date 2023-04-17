using System;

namespace Others
{
    public class Timer : ITimer
    {
        public bool Ready { get; private set; }
        private int _nCycles;
        private int _timerCyclesCount;

        public Timer(int nCycles)
        {
            VerifyNCycles(nCycles);
            _nCycles = nCycles;
            _timerCyclesCount = 0;
            Ready = false;
        }

        static private void VerifyNCycles(int nCycles)
        {
            if (nCycles <= 0)
            {
                throw new ArgumentException("Timer must be set to a positive integer!");
            }
        }

        public void Reset() => _timerCyclesCount = 0;

        public void SetNumCycles(int newNumCycles)
        {
            VerifyNCycles(newNumCycles);
            if (_timerCyclesCount >= newNumCycles)
            {
                _timerCyclesCount = newNumCycles - 1;
            }
            _nCycles = newNumCycles;
        }

        public void UpdateState()
        {
            _timerCyclesCount = (_timerCyclesCount + 1) % _nCycles;
            Ready = _timerCyclesCount == 0;
        }
    }
}
