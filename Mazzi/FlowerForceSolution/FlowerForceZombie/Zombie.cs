using Others;
using System.Drawing;

namespace FlowerForceZombie
{
    public class Zombie : AbstractLivingEntity, IZombie
    {
        private const int FreezeFactor = 2;
        private const int FreezeWaitingSecs = 9;
        private const int EatWaitingSecs = 1;
        static private readonly int FreezeWaitingTicks = RenderingInformation.ConvertSecondsToCycles(FreezeWaitingSecs);
        static private readonly int EatWaitingTicks = RenderingInformation.ConvertSecondsToCycles(EatWaitingSecs);
        private readonly ITimer _freezeTimer;
        private readonly int _damage;
        private bool _isFrozen;
        private bool _canBite;
        private float _defaultDelta;
        public int Difficulty { get; }
        public float Delta { get; private set; }

        public Zombie(float defaultDelta, int damage, int health, PointF position, int difficulty,
            string zombieName) : base(position, new MyTimer(EatWaitingTicks), health, zombieName)
        {
            _defaultDelta = defaultDelta;
            _damage = damage;
            _freezeTimer = new MyTimer(FreezeWaitingTicks);
            Difficulty = difficulty;
            _isFrozen = false;
            _canBite = true;
            Delta = defaultDelta;
        }

        public override void UpdateState()
        {
            if (_isFrozen)
            {
                _freezeTimer.UpdateState();
                if (_freezeTimer.Ready)
                {
                    WarmUp();
                }
            }
            if (!_canBite)
            {
                base.UpdateState();
                if (Timer.Ready)
                {
                    _canBite = true;
                }
            }
        }

        public void Freeze()
        {
            _freezeTimer.Reset();
            if (!_isFrozen)
            {
                Delta = _defaultDelta / FreezeFactor;
                Timer.SetNumCycles(EatWaitingTicks * FreezeFactor);
                _isFrozen = true;
            }
        }

        public bool ManageEating(IPlant plant)
        {
            if (_canBite)
            {
                plant.ReceiveDamage(_damage);
                Timer.Reset();
                _canBite = false;
                return true;
            }
            return false;
        }

        public void WarmUp()
        {
            if (_isFrozen)
            {
                _freezeTimer.Reset();
                Delta = _defaultDelta;
                Timer.SetNumCycles(EatWaitingTicks);
                _isFrozen = false;
            }
        }

        protected void ChangeVelocity(float accelerationFactor)
        {
            float newDelta = Delta * accelerationFactor;
            int newNumCycles = RenderingInformation.ConvertSecondsToCycles(EatWaitingSecs / accelerationFactor);
            Delta = _isFrozen ? newDelta / FreezeFactor : newDelta;
            _defaultDelta = newDelta;
            Timer.SetNumCycles(_isFrozen ? newNumCycles * FreezeFactor : newNumCycles);
        }

        public void Move() => SetPosition(new PointF(Position.X - Delta, Position.Y));
    }
}
