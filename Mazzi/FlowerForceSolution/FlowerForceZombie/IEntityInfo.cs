using System.Drawing;

namespace FlowerForceZombie
{
    public interface IEntityInfo
    {
        string Name { get; }

        PointF Position { get; set; }
    }
}
