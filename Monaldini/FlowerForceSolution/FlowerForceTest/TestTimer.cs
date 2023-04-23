namespace FlowerForceTest
{
    /// <summary>
    /// Test class for <see cref="ITimer"/> instances.
    /// </summary>
    [TestClass]
    public class TestTimer
    {
        private const int NumberOfCycles = 60;
        private ITimer _timer = new MyTimer(NumberOfCycles); 

        /// <summary>
        /// Sets up testing.
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            _timer = new MyTimer(NumberOfCycles);
        }

        /// <summary>
        /// Tests Ready property's logic.
        /// </summary>
        [TestMethod]
        public void TestReady()
        {
            for (int i = 0; i < NumberOfCycles - 1; i++)
            {
                _timer.UpdateState();
                Assert.IsFalse(_timer.Ready);
            }
            _timer.UpdateState();
            Assert.IsTrue(_timer.Ready);
            _timer.UpdateState();
            Assert.IsFalse(_timer.Ready);
        }

        /// <summary>
        /// Tests Reset() logic.
        /// </summary>
        [TestMethod]
        public void TestReset()
        {
            for (int i = 0; i < 10; i++)
            {
                _timer.UpdateState();
                Assert.IsFalse(_timer.Ready);
            }
            _timer.Reset();
            for (int i = 0; i < NumberOfCycles - 1; i++)
            {
                _timer.UpdateState();
                Assert.IsFalse(_timer.Ready);
            }
            _timer.UpdateState();
            Assert.IsTrue(_timer.Ready);
        }

        /// <summary>
        /// Tests NCycles property's logic.
        /// </summary>
        [TestMethod]
        public void TestSetNCycles()
        {
            for (int i = 0; i < NumberOfCycles - 1; i++)
            {
                _timer.UpdateState();
                Assert.IsFalse(_timer.Ready);
            }
            int newNumCycles = NumberOfCycles - 10;
            _timer.NCycles = newNumCycles;
            _timer.UpdateState();
            Assert.IsTrue(_timer.Ready);

            _timer.Reset();
            for (int i = 0; i < NumberOfCycles / 2; i++)
            {
                _timer.UpdateState();
                Assert.IsFalse(_timer.Ready);
            }
            _timer.NCycles = NumberOfCycles;
            for (int i = 0; i < NumberOfCycles / 2 - 1; i++)
            {
                _timer.UpdateState();
                Assert.IsFalse(_timer.Ready);
            }
            _timer.UpdateState();
            Assert.IsTrue(_timer.Ready);
        }


    }
}