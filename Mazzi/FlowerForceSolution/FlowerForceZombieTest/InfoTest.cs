namespace FlowerForceZombieTest;

[TestClass]
public class InfoTest
{
    private const string NameTest = "test";
    private const int CostTest = 100;
    private static readonly PointF PosTest = new PointF(10, 20);

    [TestMethod]
    public void TestEqualsEntityInfo()
    {
        IEntityInfo eInfo1 = new EntityInfo(NameTest, PosTest);
        IEntityInfo eInfo2 = new EntityInfo(NameTest, PosTest);
        Assert.AreNotEqual(eInfo1, eInfo2);
        IEntityInfo eInfo3 = eInfo1;
        Assert.AreEqual(eInfo1, eInfo3);
    }

    [TestMethod]
    public void TestEqualsPlantInfo() 
    {
        IPlantInfo pInfo1 = new PlantInfo(NameTest, CostTest);
        IPlantInfo pInfo2 = new PlantInfo(NameTest, CostTest);
        Assert.AreNotEqual(pInfo1, pInfo2);
        IPlantInfo pInfo3 = pInfo1;
        Assert.AreEqual(pInfo1, pInfo3);
    }

    [TestMethod]
    public void TestMoveEntityInfo() 
    {
        IZombie basic = ZombieFactory.Basic(PosTest);
        IEntityInfo eInfo = basic.EntityInfo;
        Assert.AreEqual(eInfo, basic.EntityInfo);
        basic.Move();
        Assert.AreEqual(eInfo, basic.EntityInfo); //when moved, entityInfo must remain equal
        Assert.AreEqual(eInfo.Position, basic.Position); //but also must update its position field
    }
}