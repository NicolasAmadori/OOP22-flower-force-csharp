using System.Drawing;

namespace FlowerForceZombie
{
    public interface IEntity
    {
        PointF Position { get; }

        bool Over { get; }

        string Name { get; }

        IEntityInfo EntityInfo { get; }
    }
}
