namespace Others
{
    /// <summary>
    /// This is an implementation of <see cref="IPlantInfo"/>.
    /// </summary>
    public class PlantInfo : IPlantInfo
    {
        /// <inheritdoc />
        public string Name{ get; private set; }

        /// <inheritdoc />
        public int Cost { get; private set; }

        /// <summary>
        /// This is a constructor for a specific plant info.
        /// </summary>
        /// <param name="name">The name of the plant.</param>
        /// <param name="cost">The cost of the plant.</param>
        public PlantInfo(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
