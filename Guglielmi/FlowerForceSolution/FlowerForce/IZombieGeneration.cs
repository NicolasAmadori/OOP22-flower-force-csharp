
namespace FlowerForce
{
    /// <summary>
    /// Models the game zombie generation
    /// </summary>
    public interface IZombieGeneration
    {
        /// <summary>
        /// If possible, spawn a zombie.
        /// </summary>
        /// <returns> the zombies if it has been spawned, otherwise an optional empty </returns>
        Zombie? ZombieGeneration();

        /// <summary>
        /// 
        /// </summary>
        /// <returns> the number of spawned zombie </returns>
        int SpawnedZombie { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> the number of the next horde zombie </returns>
        int NumberHordeZombie { get; }
    }
}
