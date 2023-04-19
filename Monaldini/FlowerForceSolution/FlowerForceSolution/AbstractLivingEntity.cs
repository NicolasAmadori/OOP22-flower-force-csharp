using System.Drawing;

namespace FlowerForce
{
    /// <summary>
    /// Represents an abstract <see cref="ILivingEntity"/>.
    /// </summary>
    public abstract class AbstractLivingEntity : AbstractEntity, ILivingEntity
    {

        protected MyTimer Timer { get; }
        public int Health { get; private set; }

        /// <summary>
        /// </summary>
        /// <param name="pos">the initial position to place the entity in</param>
        /// <param name="timer">used to produce bullets/suns at the right time</param>
        /// <param name="health">the starting health of the entity</param>
        /// <param name="entityName">the name of the entity</param>
        protected AbstractLivingEntity(Tuple<double, double> pos, MyTimer timer, int health, string entityName) : base(pos, entityName)
        {
            Timer = timer;
            Health = health;
        }

        /// <inheritdoc />
        public void ReceiveDamage(int damage) => Health -= damage;

        /// <inheritdoc />
        public virtual void UpdateState() => Timer.UpdateState();

        /// <inheritdoc />
        public override bool Over => this.Health <= 0;
    }
}
