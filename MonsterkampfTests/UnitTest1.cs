using Microsoft.VisualStudio.TestPlatform.TestHost;
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
            Orc mon = new (50,20,10);

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
            Orc mon = new(50, 20, 10);

            //Act
            mon.TakeDamage(dmgAmount);

            //Assert
            Assert.AreEqual(0, mon.HP);
        }
        [Test]
        public void TakeDamage_MonsterHasDP_ReducesIncomingDMGByDP()
        {
            //Arrange
            Orc mon = new(50, 20, 10);
            float dmgAmount = 30f;

            //Act
            mon.TakeDamage(dmgAmount);

            //Assert
            Assert.AreEqual(30f, mon.HP);
        }
        [Test]
        public void TakeDamage_DefenderHasMoreDPThanIncomingDmg_SetsDmgAmountNotNegative()
        {
            //Arrange
            Orc attacker = new(50, 10, 10);
            Troll defender = new(50, 10, 30);

            //Act
            attacker.Attack(defender);

            //Assert
            Assert.AreEqual(50, defender.HP);
        }

        [Test]
        public void Attack_GetsDefenderAsParameter_CallsDefendersTakeDamageMethod()
        {
            //Arrange
            Orc attacker = new(50, 10, 0);
            Troll defender = new(50, 10, 0);

            //Act
            attacker.Attack(defender);

            //Assert
            Assert.AreEqual(40f, defender.HP);
        }
        [Test]

        public void MonsterConstructor_GetsValueForHP_HPAbove30AndUnder100()
        {
            //Arrange
            Orc mon = new(120, 0, 0);
            Troll mon2 = new(20, 0, 0);

            //Act
            float monsterMaxHP = mon.HP;
            float monsterMinHP = mon2.HP;

            //Assert
            Assert.AreEqual(100, mon.HP);
            Assert.AreEqual(30, mon2.HP);
        }

        [Test]
        public void Attack_MonsterAttacksItself_CannotAttackItself()
        {
            //Arrange
            Monster mon1 = new Orc(50, 20, 10);
            Monster mon2 = new Troll(50, 20, 10);

            //Act
            bool isValid = MonsterkampfSimulator.Program.CheckValidMonster(mon1, mon1);
            bool isNotValid = MonsterkampfSimulator.Program.CheckValidMonster(mon1, mon1);

            //Assert
            Assert.IsTrue(isValid);
            Assert.IsFalse(isNotValid);
        }

    }
}