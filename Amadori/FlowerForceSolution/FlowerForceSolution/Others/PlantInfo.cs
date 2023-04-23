namespace Others
{
    public class PlantInfo : IPlantInfo
    {
        public string Name{ get; private set; }
        public int Cost { get; private set; }
        public PlantInfo(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
