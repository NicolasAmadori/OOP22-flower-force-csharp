namespace FlowerForce
{
    /// <summary>
    /// Models an in-game <see cref="IEntity"/> that is able to move.
    /// </summary>
    public interface IMovingEntity : IEntity
    {
        /// <summary>
        /// Moves the entity forward in its direction.
        /// </summary>
        void Move();

        /// <summary>
        /// Number of positions each entity moves every game loop cycle.
        /// </summary>
        double Delta { get; }
    }
}