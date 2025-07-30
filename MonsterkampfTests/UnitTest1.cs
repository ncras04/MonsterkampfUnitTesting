using MonsterkampfSimulator;
namespace MonsterkampfTests
    
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void TakeDamage_GetsValue_ReducesHPbyValue()
        {
            //Arrange
            float dmgAmount = 10;
            Monster mon = new (50,20,10);
            //Act
            mon.TakeDamage(dmgAmount);
            //Assert
            Assert.AreEqual(40, mon.HP);

        }

        [Test]
        public void TakeDamage_GetsNegativeValue_ReturnsZero()
        {
            //Arrange
            //Act
            //Assert
        }

    }
}