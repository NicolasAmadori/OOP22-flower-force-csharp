namespace FlowerForceZombieTest;

[TestClass]
public class ZombieTest
{
    private const float FreezeFactor = 2; //Freeze factor of ZombieImpl
    private const float AccelerateFactor = 3; //Accelerate factor of Newspaper Zombie
    private const int Damage = 10;
    private static readonly float InitialX = YardInfo.Yard.Width;
    private static readonly float InitialY = YardInfo.Yard.Height;
    private IZombie _zombie = ZombieFactory.Basic(new PointF(InitialX, InitialY));
    private IZombie _newspaper = ZombieFactory.Newspaper(new PointF(InitialX, InitialY));

    [TestInitialize]
    public void Setup() 
    {
        _zombie = ZombieFactory.Basic(new PointF(InitialX, InitialY));
        _newspaper = ZombieFactory.Newspaper(new PointF(InitialX, InitialY));
    }

    [TestMethod]
    public void TestMove()
    {
        float expectedPosX = InitialX;
        Assert.AreEqual(new PointF(expectedPosX, InitialY), _zombie.Position);
        _zombie.Move();
        expectedPosX -= _zombie.Delta;
        Assert.AreEqual(new PointF(expectedPosX, InitialY), _zombie.Position);
        _zombie.Move();
        expectedPosX -= _zombie.Delta;
        _zombie.Move();
        expectedPosX -= _zombie.Delta;
        Assert.AreEqual(new PointF(expectedPosX, InitialY), _zombie.Position);
    }

    [TestMethod]
    public void TestFreeze() 
    {
        float initialDelta = _zombie.Delta;
        float expectedDelta = initialDelta;
        Assert.AreEqual(expectedDelta, _zombie.Delta);
        _zombie.Freeze();
        expectedDelta = expectedDelta / FreezeFactor;
        Assert.AreEqual(expectedDelta, _zombie.Delta);
        _zombie.Freeze();
        _zombie.Freeze();
        //delta must remain the same because the zombie is already frozen
        Assert.AreEqual(expectedDelta, _zombie.Delta);
        //with warmUp method zombie must restore its initial velocity
        _zombie.WarmUp();
        Assert.AreEqual(initialDelta, _zombie.Delta);
    }

    [TestMethod]
    public void TestReceiveDamage() 
    {
        int expectedHealth = _zombie.Health;
        Assert.AreEqual(expectedHealth, _zombie.Health);
        _zombie.ReceiveDamage(Damage);
        expectedHealth -= Damage;
        Assert.AreEqual(expectedHealth, _zombie.Health);
        _zombie.ReceiveDamage(2 * Damage);
        expectedHealth -= 2 * Damage;
        Assert.AreEqual(expectedHealth, _zombie.Health);
    }

    [TestMethod]
    public void TestNewspaper()
    {
        double initialDelta = _newspaper.Delta;
        while (_newspaper.Delta == initialDelta) 
        {
            _newspaper.ReceiveDamage(Damage);
        }
        //Must accelerate after receiving some damage
        Assert.AreEqual(initialDelta * AccelerateFactor, _newspaper.Delta);
    }
}