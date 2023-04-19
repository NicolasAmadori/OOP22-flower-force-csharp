using System.Drawing;

namespace FlowerForce
{
    /// <summary>
    /// Models an in-game entity.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// The entity's position.
        /// </summary>
        Tuple<double, double> Position { get; }

        /// <summary>
        /// the name of the entity (this is not an identifier, there could be two or more entities with the same name).
        /// </summary>
        string Name { get; }

        /// <summary>
        /// true if the entity doesn't have to be in game anymore
        /// </summary>
        bool Over { get; }
    }
}
