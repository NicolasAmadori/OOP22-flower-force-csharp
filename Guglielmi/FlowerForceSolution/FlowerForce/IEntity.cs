using System.Drawing;

namespace FlowerForce
{
    /// <summary>
    /// Models an in-game entity.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value> the entity's position </value>
        PointF Position { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> true if the entity doesn't have to be in game anymore </returns>
        bool IsOver();

        /// <summary>
        /// 
        /// </summary>
        /// <value> the name of the entity (this is not an identifier,
        /// there could be two or more entities with the same name) </value>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <value> the info about the name and the position of the entity, 
        /// wrapped in an unique object (in order to be a key of maps) </value>
        IEntityInfo EntityInfo { get; }
    }
}
