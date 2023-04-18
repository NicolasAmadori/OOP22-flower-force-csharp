using Others;
using System.Drawing;

namespace FlowerForceZombie
{
    /// <summary>
    /// Implementation of <see cref="IZombie"/>
    /// </summary>
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

        /// <summary>
        /// Creates a new zombie
        /// </summary>
        /// <param name="defaultDelta"> is the space traveled by the zombie every move update </param>
        /// <param name="damage"> given by the zombie </param>
        /// <param name="health"> of the zombie </param>
        /// <param name="position"> of the zombie </param>
        /// <param name="difficulty"> the generic difficulty of the zombie </param>
        /// <param name="zombieName"> the name of the zombie </param>
        /// <returns></returns>
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

        /// <inheritdoc />
        public int Difficulty { get; }

        /// <inheritdoc />
        public float Delta { get; private set; }

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <summary>
        /// This method can be called by subtypes to change 
        /// the total velocity of the zombie (i.e its moving and eating velocity)
        /// </summary>
        /// <param name="accelerationFactor"> used to change zombie velocity </param>
        protected void ChangeVelocity(float accelerationFactor)
        {
            float newDelta = Delta * accelerationFactor;
            int newNumCycles = RenderingInformation.ConvertSecondsToCycles(EatWaitingSecs / accelerationFactor);
            Delta = _isFrozen ? newDelta / FreezeFactor : newDelta;
            _defaultDelta = newDelta;
            Timer.SetNumCycles(_isFrozen ? newNumCycles * FreezeFactor : newNumCycles);
        }

        /// <inheritdoc />
        public void Move() => SetPosition(new PointF(Position.X - Delta, Position.Y));
    }
}
