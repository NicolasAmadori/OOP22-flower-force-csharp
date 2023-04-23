using System.Drawing;

namespace FlowerForce
{
    /// <summary>
    /// Models the game zombie generation in a level game.
    /// </summary>
    public interface IZombieGenerationLevel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boss"> to generate </param>
        /// <returns> the boss of the level </returns>
        Zombie BossGeneration(Func<PointF, Zombie> boss);
    }
}
