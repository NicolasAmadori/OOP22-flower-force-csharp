using System;

namespace FlowerForce
{
    /// <summary>
    /// Models an in-game <see cref="IEntity"/> with an health associated.
    /// </summary>
    public interface ILivingEntity : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns> the remaining health </returns>
        int Health { get; }

        /// <summary>
        /// Called to do some damage on the entity.
        /// </summary>
        /// <param name="damge"> the damage to do </param>
        void ReceiveDamage(int damge);

        /// <summary>
        /// Called to update an entity's internal state.
        /// </summary>
        void UpdateState();
    }
}
