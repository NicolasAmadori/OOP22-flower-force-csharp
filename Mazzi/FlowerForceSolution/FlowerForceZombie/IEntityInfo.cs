using System.Drawing;

namespace FlowerForceZombie
{
    /// <summary>
    /// Models the info that must be saved about an <see cref="IEntity"/> for external usage.
    /// It also wraps these informations inside an unique istance.
    /// </summary>
    public interface IEntityInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value> the name of the entity </value>
        string Name { get; }

        /// <summary>
        /// Position must be updated with the one inside of entity.
        /// </summary>
        /// <value> the position of the entity </value>
        PointF Position { get; set; }
    }
}
