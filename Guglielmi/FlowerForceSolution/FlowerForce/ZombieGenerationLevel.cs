using Others;
using System;
using System.Drawing;

namespace FlowerForce
{
    /// <summary>
    /// This is an implementation of <see cref="IZombieGenerationLevel"/>
    /// </summary>
    public class ZombieGenerationLevel : AbstractZombieGeneration, IZombieGenerationLevel
    {
        private const int StartNumberZombieInHorde = 10;
        private const int ZombieBefore_Horde = 7;

        private Random _rand  = new Random();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="levelId"> of the game started </param>
        public ZombieGenerationLevel(int levelId) : base(levelId, ZombieBefore_Horde, StartNumberZombieInHorde)
        { }

        /// <inheritdoc />
        public Zombie BossGeneration(Func<PointF, Zombie> boss)
            => boss(YardInfo.GetEntityPosition(_rand.Next(YardInfo.Rows),YardInfo.Cols));
    }
}
