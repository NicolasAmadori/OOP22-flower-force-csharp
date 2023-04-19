namespace FlowerForceTest
{
    [TestClass]
    public class TestShootingPlant
    {
        private const double StandardSecsShootingTime = 1.425;
        private static int StandardShootingTime = RenderingInformation.ConvertSecondsToCycles(StandardSecsShootingTime);

        private readonly IShootingPlant _peaShooter = ShootingPlantFactory.CreatePeaShooter(Tuple.Create(0.0, 0.0));

        [TestMethod]
        public void TestReceiveDamage()
        {
            int testDamage = 10;
            for (int i = 0; i < 3; i++)
            {
                int startingHealth = _peaShooter.Health;
                _peaShooter.ReceiveDamage(testDamage);
                Assert.AreEqual(startingHealth - testDamage, _peaShooter.Health);
                Assert.IsFalse(_peaShooter.Over);
            }
        }

        [TestMethod]
        public void TestShooting()
        {
            for (int i = 0; i < StandardShootingTime - 1; i++)
            {
                _peaShooter.UpdateState();
                Assert.IsNull(_peaShooter.NextBullet);
            }
            _peaShooter.UpdateState();
            Assert.IsNotNull(_peaShooter.NextBullet);
            _peaShooter.UpdateState();
            Assert.IsNull(_peaShooter.NextBullet);
        }
    }
}
