using System.Drawing;

namespace FlowerForceZombie
{
    /// <summary>
    /// This class models a newspaper zombie that extends <see cref="Zombie"/>, so that
    /// it can accelerate after receiving a certain damage.
    /// </summary>
    public class NewspaperZombie : Zombie 
    {
        private const int AccelerateFactor = 3; //3x
        private readonly int _criticalHealth;
        private bool _isRunning;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultDelta"> is the space traveled by the zombie every move update </param>
        /// <param name="damage"> given by the zombie </param>
        /// <param name="health">  of the zombie </param>
        /// <param name="position">  of the zombie </param>
        /// <param name="newspaperHealth"> the health of its newspaper </param>
        /// <param name="difficulty">  of the zombie </param>
        /// <param name="zombieName"> the name of the zombie </param>
        /// <returns></returns>
        public NewspaperZombie(float defaultDelta, int damage, int health, PointF position, int newspaperHealth, 
                int difficulty, string zombieName) : base(defaultDelta, damage,
                    health + newspaperHealth, position, difficulty, zombieName)
        {
            _criticalHealth = health;
            _isRunning = false;
        }

        /// <summary>
        /// Override of <see cref="AbstractLivingEntity.ReceiveDamage(int)"/>,
        /// so that <see cref="NewspaperZombie"/> can accelerate after receiving a certain damage.
        /// </summary>
        /// <param name="damage"> to receive </param>
        public override void ReceiveDamage(int damage)
        {
            base.ReceiveDamage(damage);
            if (!_isRunning && Health <= _criticalHealth)
            {
                ChangeVelocity(AccelerateFactor);
                _isRunning = true;
            }
        }
    }
}
