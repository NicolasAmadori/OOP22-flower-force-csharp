using FlowerForceZombie;

namespace Others
{
    public interface IPlant : ILivingEntity
    {
        int Cost { get; }

        int RechargeTime { get; }
    }
}
