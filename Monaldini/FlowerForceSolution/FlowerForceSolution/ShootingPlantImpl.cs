namespace FlowerForce
{
    public class ShootingPlantImpl : AbstractPlant, IShootingPlant
    {
        private readonly Func<IBullet> _bulletProducer;
        private bool _canShoot;

        /// <summary>
        /// </summary>
        /// <param name="pos">the initial position to place the entity in</param>
        /// <param name="timer">used to produce bullets at the right time</param>
        /// <param name="health">the starting health of the entity</param>
        /// <param name="bulletProducer">the producer of the bullets for this plant</param>
        /// <param name="cost">plant's cost</param>
        /// <param name="rechargeTime">plant's recharge time</param>
        /// <param name="plantName">plant's name</param>
        public ShootingPlantImpl(
            Tuple<double, double> pos,
            Timer timer,
            int health,
            Func<IBullet> bulletProducer,
            int cost,
            int rechargeTime,
            string plantName) : base (pos, timer, health, cost, rechargeTime, plantName)
        {
            _bulletProducer = bulletProducer;
        }

        /// <inheritdoc />
        public IBullet? NextBullet
        {
            get
            {
                IBullet? nextBullet = Enumerable.Repeat(_canShoot, 1)
                                                .Where(p => p)
                                                .Select(x => _bulletProducer.Invoke())
                                                .FirstOrDefault();
                if (_canShoot)
                {
                    _canShoot = false;
                    Timer.Reset();
                }
                return nextBullet;
            }
        }

        /// <inheritdoc />
        public override void UpdateState()
        { 
            base.UpdateState();
            if (Timer.Ready)
            {
                _canShoot = true;
            }
        }
    }
}
