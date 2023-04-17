using System.Drawing;

namespace FlowerForceZombie
{
    class EntityInfo : IEntityInfo
    {
        public string Name { get; }
        public PointF Position { get; set; }

        public EntityInfo(string name, PointF position)
        {
            Name = name;
            Position = position;
        }
    }
}
