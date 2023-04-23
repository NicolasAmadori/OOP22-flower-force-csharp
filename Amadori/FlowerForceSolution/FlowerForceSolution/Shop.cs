using Others;

namespace FlowerForceSolution
{

    /// <summary>
    /// This is an implementation of <see cref="IShop"/>.
    /// </summary>
    public class Shop : IShop
    {
        private const IList<Tuple<Func<Tuple<double, double>, IPlant>, int>> SHOP_PLANTS = null;

        private IPlayer _player;
        private IList<IPlantInfo> _plants = new List<IPlantInfo>();

        /// <inheritdoc />
        public IDictionary<IPlantInfo, bool> Plants
        {
            get
            {
                var outputMap = new Dictionary<IPlantInfo, bool>();
                var playerPlants = GetPlayerBoughtPlants();
                _plants.ToList().ForEach(p =>
                    outputMap.Add(p,
                                  !playerPlants.Contains(p) && _player.Coins >= p.Cost));
                return outputMap;
            }
        }

        /// <inheritdoc />
        public ISet<Func<Tuple<double, double>, IPlant>> BoughtPlantsFunctions
        {
            get => _player.PlantsIds.ToList()
                    .Select(id => SHOP_PLANTS[id].Item1)
                    .ToHashSet();
        }

        /// <summary>
        /// This is a constructor for a new shop instance.
        /// </summary>
        /// <param name="p">The player to add bought plants to</param>
        public Shop(IPlayer player)
        {
            _player = player;

            //Adding all plants in the map
            var samplePoint = new Tuple<double, double>(0, 0);
            SHOP_PLANTS.ToList().ForEach(p => _plants.Add(
                      new PlantInfo(
                          p.Item1.Invoke(samplePoint).Name,
                          p.Item2)));
        }

        /// <inheritdoc />
        public bool BuyPlant(IPlantInfo plantInfo)
        {
            if (_plants.Contains(plantInfo) && _player.SubtractCoins(plantInfo.Cost))
            {
                _player.AddPlant(GetKeyIndex(plantInfo));
                return true;
            }
            return false;
        }

        private ISet<IPlantInfo> GetPlayerBoughtPlants()
        {
            return _player.PlantsIds.ToList()
                .Select(p => _plants[p])
                .ToHashSet();
        }

        private int GetKeyIndex(IPlantInfo plantInfo) => _plants.IndexOf(plantInfo);
    }
}
