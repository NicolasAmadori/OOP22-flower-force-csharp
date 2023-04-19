namespace FlowerForce
{
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
