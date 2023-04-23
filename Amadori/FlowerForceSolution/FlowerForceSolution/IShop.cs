using Others;

namespace FlowerForceSolution
{
    /// <summary>
    /// This is a shop class to show and buy new plants.
    /// </summary>
    public interface IShop
    {
        /// <summary>
        /// All the plants contained in the shop.
        /// </summary>
        IDictionary<IPlantInfo, bool> Plants { get; }

        /// <summary>
        /// All the function producer of the plants instances.
        /// </summary>
        ISet<Func<Tuple<double, double>, IPlant>> BoughtPlantsFunctions { get; }

        /// <summary>
        /// Buy a certain plant from the shop.
        /// </summary>
        /// <param name="plantInfo">The information of the plant to buy.</param>
        /// <returns>True if the plant was successfully bought, false otherwise.</returns>
        bool BuyPlant(IPlantInfo plantInfo);
    }
}
