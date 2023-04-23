namespace FlowerForce
{
    /// <summary>
    /// A factory that generates <see cref="IShootingPlant"/> instances.
    /// </summary>
    public static class ShootingPlantFactory
    {
        private const double StandardSecsShootingTime = 1.425;
        private static int StandardShootingTime = (int) (
            StandardSecsShootingTime * RenderingInformation.FramesPerSecond);
        private const int StandardShooterHealth = 300;
        private const int StrongShooterHealth = StandardShooterHealth / 10;

        private const int CommonShooterCost = 100;
        private const int SnowShooterCost = 175;
        private const int FireShooterCost = 225;
        private const int FastShooterCost = 200;
        private const int StrongShooterCost = 250;

        /// <summary>
        /// Creates a Pea Shooter Plant.
        /// </summary>
        /// <param name="pos">the position where to place it</param>
        /// <returns>a Pea Shooter Plant</returns>
        public static IShootingPlant CreatePeaShooter(Tuple<double, double> pos)
            => new ShootingPlant(
                pos,
                new MyTimer(StandardShootingTime),
                StandardShooterHealth,
                () => BulletFactory.CreateStandardBullet(pos),
                CommonShooterCost,
                RechargeTimes.FastRechargeTime,
                "peashooter");

        /// <summary>
        /// Creates a Fire Shooter Plant.
        /// </summary>
        /// <param name="pos">the position where to place it</param>
        /// <returns>a Fire Shooter Plant</returns>
        public static IShootingPlant CreateFireShooter(Tuple<double, double> pos)
            => new ShootingPlant(
                pos,
                new MyTimer(StandardShootingTime),
                StandardShooterHealth,
                () => BulletFactory.CreateFireBullet(pos),
                FireShooterCost,
                RechargeTimes.FastRechargeTime,
                "fireshooter");

        /// <summary>
        /// Creates a Snow Shooter Plant.
        /// </summary>
        /// <param name="pos">the position where to place it</param>
        /// <returns>a Snow Shooter Plant</returns>
        public static IShootingPlant CreateSnowShooter(Tuple<double, double> pos)
            => new ShootingPlant(
                pos,
                new MyTimer(StandardShootingTime),
                StandardShooterHealth,
                () => BulletFactory.CreateSnowBullet(pos),
                SnowShooterCost,
                RechargeTimes.FastRechargeTime,
                "snowshooter");

        /// <summary>
        /// Creates a Fast Shooter Plant.
        /// </summary>
        /// <param name="pos">the position where to place it</param>
        /// <returns>a Fast Shooter Plant</returns>
        public static IShootingPlant CreateFastShooter(Tuple<double, double> pos)
            => new ShootingPlant(
                pos,
                new MyTimer(StandardShootingTime / 2),
                StandardShooterHealth,
                () => BulletFactory.CreateStandardBullet(pos),
                FastShooterCost,
                RechargeTimes.FastRechargeTime,
                "fastshooter");

        /// <summary>
        /// Creates a Strong Shooter Plant.
        /// </summary>
        /// <param name="pos">the position where to place it</param>
        /// <returns>a Strong Shooter Plant</returns>
        public static IShootingPlant CreateStrongShooter(Tuple<double, double> pos)
            => new ShootingPlant(
                pos,
                new MyTimer(StandardShootingTime * 10),
                StrongShooterHealth,
                () => BulletFactory.CreateStrongBullet(pos),
                StrongShooterCost,
                RechargeTimes.VerySlowRechargeTime,
                "strongshooter");
    }
}
