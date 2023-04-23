namespace FlowerForce
{
    /// <summary>
    /// An interface modelling any kind of plants.
    /// </summary>
    public interface IPlant : ILivingEntity
    {
        /// <summary>
        /// The plant's cost
        /// </summary>
        int Cost { get; }

        /// <summary>
        /// The plant's recharge time
        /// </summary>
        int RechargeTime { get; }
    }
}
