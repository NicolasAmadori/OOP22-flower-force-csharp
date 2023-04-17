namespace FlowerForceZombieTest;

[TestClass]
public class ZombieTest
{
    private static readonly float InitialX = YardInfo.Yard.Width;
    private static readonly float InitialY = YardInfo.Yard.Height;
    private const float FreezeFactor = 2; //Freeze factor of ZombieImpl
    private const float AccelerateFactor = 3; //Accelerate factor of Newspaper Zombie
    private const int Damage = 10;
    private IZombie _zombie = ZombieFactory.Basic(new PointF(InitialX, InitialY));
    private IZombie _newspaper = ZombieFactory.Newspaper(new PointF(InitialX, InitialY));

    [TestInitialize]
    public void Setup() {
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
}