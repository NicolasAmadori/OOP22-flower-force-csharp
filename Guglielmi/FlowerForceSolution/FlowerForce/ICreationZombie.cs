
namespace FlowerForce
{
    /// <summary>
    /// Models a zombie spawn.
    /// </summary>
    public interface ICreationZombie
    {

        /// <summary>
        /// Used for the creation of a new zombie.
        /// </summary>
        /// <param name="delta"> used to manage the probability of spawning the various zombies </param>
        /// <returns> the spawned zombie </returns>
        Zombie creationZombie(int delta);

        /// <summary>
        /// Used to increase the zombie level possible to spawn.
        /// </summary>
        void increaseLevelZombieToSpawn();
    }
}
