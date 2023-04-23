using System.Drawing;

namespace FlowerForce
{
    /// <summary>
    /// Models the info that must be saved about an <see cref="IEntity"/> for external usage.
    /// It also wraps these informations inside an unique istance.
    /// </summary>
    public interface IEntityInfo
    {
        /// <summary>
        /// the name of the entity
        /// </summary>
        string Name { get; }

        /// <summary>
        /// the position of the entity
        /// </summary>
        PointF Position { get; set; }
    }
}
