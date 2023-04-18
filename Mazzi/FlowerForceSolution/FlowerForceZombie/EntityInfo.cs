using System.Drawing;

namespace FlowerForceZombie
{
    /// <summary>
    /// Implementation of <see cref="IEntityInfo"/>.
    /// </summary>
    public class EntityInfo : IEntityInfo
    {
        /// <summary>
        /// Creates a new unique object with the info of a generic <see cref="IEntity"/>.
        /// </summary>
        /// <param name="name"> of the entity </param>
        /// <param name="position"> of the entity </param>
        public EntityInfo(string name, PointF position)
        {
            Name = name;
            Position = position;
        }

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public PointF Position { get; set; }
    }
}
