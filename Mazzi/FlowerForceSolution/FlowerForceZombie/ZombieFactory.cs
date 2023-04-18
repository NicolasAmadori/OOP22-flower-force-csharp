using Others;
using System.Drawing;

namespace FlowerForceZombie
{
    /// <summary>
    /// Static factory of different types of <see cref="IZombie"/>.
    /// </summary>
    public static class ZombieFactory
    {
        private const int BasicHealth = 181;
        private const int BasicDamage = 100;
        private const int ConeHealth = 370;
        private const int BucketHealth = 1100;
        private const int HelmetHealth = 1400;
        private const int NewspaperHealth = 200;
        private const int GargantuarHealth = 4000;
        private const int GargantuarDamage = 10_000;
        private const double BasicSecsPerCell = 4.7;
        static private readonly float BasicDelta = RenderingInformation.GetDeltaFromSecondsPerCell(BasicSecsPerCell);
        static private readonly float RunningDelta = 2 * BasicDelta;
        private const int BasicDifficulty = 1;
        private const int ConeheadDifficulty = 2;
        private const int RunningDifficulty = 3;
        private const int NewspaperDifficulty = 3;
        private const int BucketheadDifficulty = 4;
        private const int QuarterbackDifficulty = 6;
        private const int GargantuarDifficulty = 10;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> where it is initially placed </param>
        /// <returns> a basic zombie </returns>
        public static IZombie Basic(PointF position)    
            => new Zombie(BasicDelta, BasicDamage, BasicHealth, position, BasicDifficulty, "basic");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> where it is initially placed </param>
        /// <returns> a medium-resistance zombie </returns>
        public static IZombie Conehead(PointF position)
            => new Zombie(BasicDelta, BasicDamage, BasicHealth + ConeHealth, position, ConeheadDifficulty, "conehead");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> where it is initially placed </param>
        /// <returns> a high-resistance zombie </returns>
        public static IZombie Buckethead(PointF position)
            => new Zombie(BasicDelta, BasicDamage, BasicHealth + BucketHealth, position, BucketheadDifficulty, "buckethead");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> where it is initially placed </param>
        /// <returns> a running zombie </returns>
        public static IZombie Runner(PointF position)
            => new Zombie(RunningDelta, BasicDamage, BasicHealth, position, RunningDifficulty, "runner");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> where it is initially placed </param>
        /// <returns> a running and high-resistance zombie </returns>
        public static IZombie Quarterback(PointF position)
            => new Zombie(RunningDelta, BasicDamage, BasicHealth + HelmetHealth, 
                position, QuarterbackDifficulty, "quarterback");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> where it is initially placed </param>
        /// <returns> a medium resistance zombie, that starts running after its newspaper gets destroyed </returns>
        public static IZombie Newspaper(PointF position)
            => new NewspaperZombie(BasicDelta, BasicDamage, BasicHealth, position,
                NewspaperHealth, NewspaperDifficulty, "newspaper");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> where it is initially placed </param>
        /// <returns> an enormous zombie, with enormous damage and resistance </returns>
        public static IZombie Gargantuar(PointF position)
            => new Zombie(BasicDelta, GargantuarDamage, GargantuarHealth, position, GargantuarDifficulty, "gargantuar");
    }
}
