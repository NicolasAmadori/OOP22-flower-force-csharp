
namespace FlowerForceZombie
{
    public interface IMovingEntity : IEntity
    {
        void Move();

        double Delta { get; }
    }
}
