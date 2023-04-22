using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
