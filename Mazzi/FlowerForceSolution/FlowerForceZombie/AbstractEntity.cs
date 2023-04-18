using System.Drawing;

namespace FlowerForceZombie
{
    /// <summary>
    /// Represents an abstract <see cref="IEntity"/>.
    /// </summary>
    public abstract class AbstractEntity : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> the position of the entity </param>
        /// <param name="name"> the name of the entity </param>
        protected AbstractEntity(PointF position, string name)
        {
            Position = position;
            Name = name;
            EntityInfo = new EntityInfo(name, position);
        }

        /// <inheritdoc />
        public PointF Position { get; private set; }

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public IEntityInfo EntityInfo { get; }

        /// <inheritdoc />
        public bool Over { get; protected set; }

        /// <summary>
        /// Called by subclasses to update entity's position.
        /// </summary>
        /// <param name="newPos"> the new entity's position </param>
        protected void SetPosition(PointF newPos)
        {
            Position = newPos;
            EntityInfo.Position = newPos;
        }
    }
}
