using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerForce
{
    /// <summary>
    /// Models world levels, it contains level information.
    /// </summary>
    public static class LevelInfo
    {
        private static readonly List<Func<PointF, Zombie>> AvaiableZombies = new List<Func<PointF, Zombie>>()
        {
            pos => (Zombie)ZombieFactory.Basic(pos),
            pos => (Zombie)ZombieFactory.Conehead(pos),
            pos => (Zombie)ZombieFactory.Runner(pos),
            pos => (Zombie)ZombieFactory.Buckethead(pos),
            pos => (Zombie)ZombieFactory.Gargantuar(pos)
        };
        private const int Coins = 100;
        private static readonly List<int> ZombieLevel = new List<int>() { 34, 51, 68, 68, 85, 85 };
        private static readonly Func<PointF, Zombie> ZombieBoss = pos => (Zombie)ZombieFactory.Gargantuar(pos);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> of the level </param>
        /// <returns> the coins you get if you pass the level </returns>
        public static int GetLevelCoins(int id)
            => Coins * id;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> id of the level </param>
        /// <returns> the available zombies on that level </returns>
        public static List<Func<PointF, Zombie>> GetZombiesInfo(int id)
            => AvaiableZombies.GetRange(0, Math.Min(1 + id, AvaiableZombies.Count));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> of the level </param>
        /// <returns> the zombie to spawn on that level </returns>
        public static int GetTotalZombies(int id)
            => ZombieLevel.ToArray()[Math.Min(id - 1, ZombieLevel.Count - 1)];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> of the level </param>
        /// <returns> if it is present, the level boss </returns>
        public static Func<PointF, Zombie>? GetBossId(int id)
            => 1 + id > AvaiableZombies.Count ? ZombieBoss : null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns> the last level ID </returns>
        public static int GetLastLevelId()
            => AvaiableZombies.Count;
    }
}
