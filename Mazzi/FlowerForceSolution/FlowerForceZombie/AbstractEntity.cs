using System.Drawing;

namespace FlowerForceZombie
{
    public abstract class AbstractEntity : IEntity
    {
        public PointF Position { get; protected set; }
        public string Name { get; }
        public IEntityInfo EntityInfo { get; }
        public bool Over { get; protected set; }

        protected AbstractEntity(PointF position, string name)
        {
            Position = position;
            Name = name;
            EntityInfo = new EntityInfo(name, position);
        }
    }
}
