
namespace FlowerForceZombie 
{
    /// <summary>
    /// Models the info that must be saved about a plant in order to identify its type in maps.
    /// </summary>
    public interface IPlantInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value> the name of the plant </value>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <value> the cost of the plant </value>
        int Cost { get; }
    }
}