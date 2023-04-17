
namespace FlowerForceZombie
{
    public interface IMovingEntity : IEntity
    {
        void Move();

        float Delta { get; }
    }
}
