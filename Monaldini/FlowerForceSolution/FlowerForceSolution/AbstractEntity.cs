namespace FlowerForce
{
    /// <summary>
    /// This is an abstract implementation of <see cref="IEntity"/>.
    /// </summary>
    public abstract class AbstractEntity : IEntity
    {


        /// <inheritdoc />
        public Tuple<double, double> Position { get; protected set; }

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public abstract bool Over { get; }

        /// <summary>
        /// </summary>
        /// <param name="pos">The position of the entity</param>
        /// <param name="name">The name of the entity</param>
        protected AbstractEntity(Tuple<double, double> pos, String name)
        {
            Name = name;
            Position = pos;
        }

    }
}
