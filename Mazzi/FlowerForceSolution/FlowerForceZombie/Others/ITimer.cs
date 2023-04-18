
namespace Others
{
    /// <summary>
    /// Models a timer based on game loop's cycles, used by entities for synchronization.
    /// The timer gets updated every cycle and becomes ready every N times it's updated
    /// (with N greater than 0).
    /// </summary>
    public interface ITimer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value> true if timer is ready </value>
        bool Ready { get; }

        /// <summary>
        /// Sets the timer to a number of cycles (greater than 0).
        /// </summary>
        /// <param name="newNCycles"> number the timer is set to </param>
        void SetNumCycles(int newNCycles);

        /// <summary>
        /// Updates timer's internal state.
        /// </summary>
        void UpdateState();

        /// <summary>
        /// Resets the timer to the initial value.
        /// </summary>
        void Reset();
    }
}
