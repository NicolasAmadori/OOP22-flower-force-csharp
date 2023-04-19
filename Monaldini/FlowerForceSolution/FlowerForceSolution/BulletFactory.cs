using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FlowerForce
{
    /// <summary>
    /// Models a factory for <see cref="IBullet"/> entities.
    /// </summary>
    public static class BulletFactory
    {
        private const int StandardDamage = 20;
        private const int FireDamage = StandardDamage * 3;
        private const int StrongDamage = StandardDamage * 25;

        /// <summary>
        /// Creates a standard bullet.
        /// </summary>
        /// <param name="pos">the position to place the bullet in</param>
        /// <returns>a standard bullet in the given position</returns>
        public static IBullet CreateStandardBullet(Tuple<double, double> pos)
            => new Bullet(pos, StandardDamage, "standardbullet");

        /// <summary>
        /// Creates a fire bullet.
        /// </summary>
        /// <param name="pos">the position to place the bullet in</param>
        /// <returns>a fire bullet in the given position</returns>
        public static IBullet CreateFireBullet(Tuple<double, double> pos)
            => new Bullet(pos, FireDamage, "firebullet", z => z.WarmUp());

        /// <summary>
        /// Creates a snow bullet.
        /// </summary>
        /// <param name="pos">the position to place the bullet in</param>
        /// <returns>a snow bullet in the given position</returns>
        public static IBullet CreateSnowBullet(Tuple<double, double> pos)
            => new Bullet(pos, StandardDamage, "snowbullet", z => z.Freeze());

        /// <summary>
        /// Creates a strong bullet.
        /// </summary>
        /// <param name="pos">the position to place the bullet in</param>
        /// <returns>a strong bullet in the given position</returns>
        public static IBullet CreateStrongBullet(Tuple<double, double> pos)
            => new Bullet(pos, StrongDamage, "strongbullet");
    }
}
