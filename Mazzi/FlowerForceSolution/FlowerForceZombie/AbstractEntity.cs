using System.Drawing;

namespace FlowerForceZombie
{
    public abstract class AbstractEntity : IEntity
    {
        protected AbstractEntity(PointF position, string name)
        {
            Position = position;
            Name = name;
            EntityInfo = new EntityInfo(name, position);
        }

        public PointF Position { get; private set; }

        public string Name { get; }

        public IEntityInfo EntityInfo { get; }

        public bool Over { get; protected set; }

        protected void SetPosition(PointF newPos)
        {
            Position = newPos;
            EntityInfo.Position = newPos;
        }
    }
}
