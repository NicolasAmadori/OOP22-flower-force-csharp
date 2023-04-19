namespace FlowerForceTest
{
    [TestClass]
    public class TestBullet
    {
        private readonly IBullet _bullet = BulletFactory.CreateStandardBullet(Tuple.Create(0.0, 0.0));

        [TestMethod]
        public void TestMove()
        {
            for (int i = 0; i < 10; i++)
            {
                Tuple<double, double> startingPos = _bullet.Position;
                _bullet.Move();
                Assert.AreEqual(Tuple.Create(startingPos.Item1 + _bullet.Delta, startingPos.Item2), _bullet.Position);
            }
        }
    }
}
