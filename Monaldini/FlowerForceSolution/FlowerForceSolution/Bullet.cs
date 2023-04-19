using Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerForce
{
    /// <summary>
    /// Models a generic <see cref="IBullet"/>.
    /// </summary>
    public class Bullet : AbstractEntity, IBullet
    {
        private const double SecsPerCell = 0.2;

        /// <inheritdoc />;
        public double Delta { get;  }
        private readonly Action<IZombie>? _action;
        private readonly int _damage;
        private bool _hasHit;

        /// <summary>
        /// Creates a bullet that doesn't do additional actions on a zombie when hit.
        /// </summary>
        /// <param name="pos">the initial position to place the bullet in</param>
        /// <param name="damage">the damage that the bullet does to zombies</param>
        /// <param name="bulletName">the bullet's name</param>
        public Bullet(Tuple<double, double> pos, int damage, string bulletName) : this(pos, damage, bulletName, null) { }

        /// <summary>
        /// Creates a bullet that does additional actions on a zombie when hit.
        /// </summary>
        /// <param name="pos">the initial position to place the bullet in</param>
        /// <param name="damage">the damage that the bullet does to zombies</param>
        /// <param name="bulletName">the bullet's name</param>
        /// <param name="action">an action to do on a zombie when hit</param>
        public Bullet(Tuple<double, double> pos, int damage, string bulletName, Action<IZombie>? action) : base(pos, bulletName)
        {
            _damage = damage;
            _action = action;
            Delta = RenderingInformations.GetDeltaFromSecondsPerCell(SecsPerCell);
        }

        /// <inheritdoc />
        public void Hit(IZombie zombie)
        {
            _hasHit = true;
            zombie.ReceiveDamage(_damage);
            _action?.Invoke(zombie);
        }

        /// <inheritdoc />
        public void Move() => Position = Tuple.Create(Position.Item1 + Delta, Position.Item2);

        /// <inheritdoc />
        public override bool Over => _hasHit;
    }
}
