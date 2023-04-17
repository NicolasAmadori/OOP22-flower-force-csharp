using System.Drawing;

namespace FlowerForceZombie
{
    public class NewspaperZombie : Zombie 
    {
        private const int AccelerateFactor = 3;
        private readonly int _criticalHealth;
        private bool _isRunning;

        public NewspaperZombie(double defaultDelta, int damage, int health, PointF position, int newspaperHealth, 
                int difficulty, string zombieName) : base(defaultDelta, damage,
                    health + newspaperHealth, position, difficulty, zombieName)
        {
            _criticalHealth = health;
            _isRunning = false;
        }

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
