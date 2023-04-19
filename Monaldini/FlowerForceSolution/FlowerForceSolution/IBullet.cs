using System;
using Others;

namespace FlowerForce
{
    /// <summary>
    /// Models a bullet, shot by some plants against zombies.
    /// </summary>
    public interface IBullet : IMovingEntity
    {
        /// <summary>
        /// Callled to hit a zombie.
        /// </summary>
        /// <param name="zombie">the zombie to hit</param>
        void Hit(IZombie zombie);
    }
}
