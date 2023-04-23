using System.Drawing;
using Others;

namespace FlowerForce
{
    /// <summary>
    /// Represents an abstract <see cref="ILivingEntity"/>.
    /// </summary>
    public abstract class AbstractLivingEntity : AbstractEntity, ILivingEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"> the initial position to place the entity in </param>
        /// <param name="timer"> used to produce bullets/suns at the right time </param>
        /// <param name="health"> the starting health of the entity </param>
        /// <param name="name"> the name of the entity </param>
        protected AbstractLivingEntity(PointF position, MyTimer timer, int health, string name) : base(position, name)
        {
            Health = health;
            Timer = timer;
        }

        /// <inheritdoc />
        public int Health { get; private set; }

        /// <inheritdoc />
        public override bool IsOver() => Health <= 0;

        /// <inheritdoc />
        public virtual void ReceiveDamage(int damage)
        {
            Health -= damage;
        }

        /// <inheritdoc />
        public virtual void UpdateState() => Timer.UpdateState();

        /// <summary>
        /// 
        /// </summary>
        /// <value> entity's timer </value>
        protected MyTimer Timer { get; }
    }
}
