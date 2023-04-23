using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerForce
{
    /// <summary>
    /// This is an implementation of <see cref="IZombieGeneration"/>
    /// </summary>
    public class ZombieGenerationInfinite : AbstractZombieGeneration
    {
        private const int ZombieBeforeHorde = 7;
        private const int MaxZombieToSpawnHorde = 30;
        private const int IncZombieHorde = 5;
        private const int StartNumberZombieInHorde = 5;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="levelId"> of the game started </param>
        public ZombieGenerationInfinite(int levelId) : base(levelId, ZombieBeforeHorde, StartNumberZombieInHorde)
        { }

        /// <inheritdoc />
        public override Zombie? ZombieGeneration()
        {
            IncreaseHordeZombie(IncZombieHorde, MaxZombieToSpawnHorde);
            return base.ZombieGeneration();
        }
    }
}
