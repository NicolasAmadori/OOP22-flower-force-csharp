
namespace FlowerForceZombie
{
    public class PlantInfo : IPlantInfo
    {
        public PlantInfo(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; }

        public int Cost { get; }
    }
}