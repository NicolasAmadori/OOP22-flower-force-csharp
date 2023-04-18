using Others;

namespace FlowerForceZombie
{
    /// <summary>
    /// Models a zombie that is both <see cref="IMovingEntity"/> and <see cref="ILivingEntity">.
    /// </summary>
    public interface IZombie : IMovingEntity, ILivingEntity
    {
        /// <summary>
        /// Slows down the zombie
        /// </summary>
        void Freeze();

        /// <summary>
        /// Restore the original velocity of the zombie
        /// </summary>
        void WarmUp();

        /// <summary>
        /// This method can be called to manage eating a plant, indeed it will be the zombie
        /// to decide if bit it or not
        /// </summary>
        /// <param name="plant"> that can be eaten by the zombie </param>
        /// <returns> true if the zombie has bitten the plant, false otherwise </returns>
        bool ManageEating(IPlant plant);

        /// <summary>
        /// 
        /// </summary>
        /// <value> The generic difficulty of the zombie </value>
        int Difficulty { get; }
    }
}
