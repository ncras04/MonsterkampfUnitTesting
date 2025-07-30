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
            Assert.AreEqual(50, mon.HP);
        }

        [Test]
        public void TakeDamage_GetsMoreDmgThenHPAvailabe_SetsHPZero()
        {
            //Arrange
            float dmgAmount = 60f;
            Monster mon = new(50, 20, 10);

            //Act
            mon.TakeDamage(dmgAmount);

            //Assert
            Assert.AreEqual(0, mon.HP);
        }
        [Test]
        public void TakeDamage_MonsterHasDP_ReducesIncomingDMGByDP()
        {
            //Arrange
            Monster mon = new(50, 20, 10);
            float dmgAmount = 30f;

            //Act
            mon.TakeDamage(dmgAmount);

            //Assert
            Assert.AreEqual(30f, mon.HP);
        }
        [Test]
        public void Attack_GetsDefenderAsParameter_CallsDefendersTakeDamageMethod()
        {
            //Arrange
            Monster attacker = new Monster(50, 10, 0);
            Monster defender = new Monster(50, 10, 0);

            //Act
            attacker.Attack(defender);

            //Assert
            Assert.AreEqual(40f, defender.HP);
        }
    }
}