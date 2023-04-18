
namespace FlowerForceZombie
{
    /// <summary>
    /// Implementation of <see cref="IPlantInfo"/>
    /// </summary>
    public class PlantInfo : IPlantInfo
    {
        /// <summary>
        /// Creates a new unique object with the info of a generic plant.
        /// </summary>
        /// <param name="name"> of the plant </param>
        /// <param name="cost"> of the plant </param>
        public PlantInfo(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public int Cost { get; }
    }
}