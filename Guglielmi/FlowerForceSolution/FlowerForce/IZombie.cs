using Others;

namespace FlowerForce
{
	/// <summary>
	/// Models a zombie that is both <see cref="IMovingEntity"/> and <see cref="ILivingEntity">.
	/// </summary>
	public interface IZombie : ILivingEntity, IMovingEntity
	{
        /// <summary>
        /// Slows down the zombie.
        /// </summary>
        void Freeze();

        /// <summary>
        /// Restore the original velocity of the zombie.
        /// </summary>
        void WarmUp();

        /// <summary>
        /// 
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
