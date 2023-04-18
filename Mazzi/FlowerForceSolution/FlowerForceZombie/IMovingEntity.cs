
namespace FlowerForceZombie
{
    /// <summary>
    /// Models an in-game <see cref="IEntity"/> that is able to move.
    /// </summary>
    public interface IMovingEntity : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value> the number of positions each entity moves every game loop cycle </value>
        float Delta { get; }

        /// <summary>
        /// Moves the entity forward in its direction.
        /// </summary>
        void Move();

    }
}
