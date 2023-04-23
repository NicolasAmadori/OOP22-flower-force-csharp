namespace Others
{
    /// <summary>
    /// This is a class that contains the information of a specific plant.
    /// </summary>
    public interface IPlantInfo
    {
        /// <summary>
        /// The name of the plant.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The cost of the plant.
        /// </summary>
        int Cost { get; }
    }
}
