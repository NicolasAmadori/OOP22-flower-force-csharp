namespace FlowerForce
{
    /// <summary>
    /// Models a timer based on game loop's cycles, used by entities for synchronization.
    /// The timer gets updated every cycle and becomes ready every N times it's updated
    /// (with N greater than 0).
    /// </summary>
    public interface ITimer
    {
        /// <summary>
        /// Updates timer's internal state.
        /// </summary>
        void UpdateState();

        /// <summary>
        /// Resets the timer to the initial value.
        /// </summary>
        void Reset();
        
        /// <summary>
        /// The number of cycles the timer is set to (greater than 0).
        /// </summary>
        int NCycles { set; }

        /// <summary>
        /// true if the timer is ready
        /// </summary>
        bool Ready { get; }
    }
}
