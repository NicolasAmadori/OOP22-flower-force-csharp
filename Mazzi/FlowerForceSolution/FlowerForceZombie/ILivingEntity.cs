
namespace FlowerForceZombie
{
    public interface ILivingEntity : IEntity
    {
        int Health { get; }

        void ReceiveDamage(int damage);

        void UpdateState();
    }
}
