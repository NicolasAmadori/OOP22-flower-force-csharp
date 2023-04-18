using FlowerForceZombie;

namespace Others
{
    /// <summary>
    /// An interface modelling any kind of plants.
    /// </summary>
    public interface IPlant : ILivingEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value> the plant's cost </value>
        int Cost { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <value> Plant's recharge time (i.e. time until it will be avaliable again
        /// after being placed in-game) </value>
        int RechargeTime { get; }
    }
}
