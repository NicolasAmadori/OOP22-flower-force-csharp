
namespace FlowerForceZombie
{
    /// <summary>
    /// Models an in-game <see cref="IEntity"/> with an health associated.
    /// </summary>
    public interface ILivingEntity : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value> the remaining health </value>
        int Health { get; }

        /// <summary>
        /// Called to do some damage on the entity.
        /// </summary>
        /// <param name="damage"> the damage to do </param>
        void ReceiveDamage(int damage);

        /// <summary>
        /// Called to update an entity's internal state.
        /// </summary>
        void UpdateState();
    }
}
