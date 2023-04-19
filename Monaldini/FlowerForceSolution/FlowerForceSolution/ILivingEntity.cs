
namespace FlowerForce
{
    /// <summary>
    /// Models an in-game <see cref="IEntity"/> with an health associated.
    /// </summary>
    public interface ILivingEntity : IEntity
    {
        /// <summary>
        /// The entity's health.
        /// </summary>
        int Health { get; }

        /// <summary>
        /// Called to do some damage on the entity.
        /// </summary>
        /// <param name="damage">The damage to do</param>
        void ReceiveDamage(int damage);

        /// <summary>
        /// Called to update an entity's internal state.
        /// </summary>
        void UpdateState();
    }
}
