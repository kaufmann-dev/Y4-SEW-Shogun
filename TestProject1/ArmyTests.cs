using NUnit.Framework;
using Shogun;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddUnitSamuraiCount()
        {
            Army geileArmy = new Army();
            geileArmy.Add(new Horseman());
            geileArmy.Add(new Horseman());
            geileArmy.Add(new Horseman());
            geileArmy.Add(new Horseman());
            geileArmy.Add(new Horseman());
            Assert.False(geileArmy.Add(new Horseman()));
        }

        [Test]
        public void TestAddUnitAshigaruCount()
        {
            Army geileArmy2 = new Army();
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            geileArmy2.Add(new Gunner());
            Assert.False(geileArmy2.Add(new Gunner()));
        }

        [Test]
        public void TestAddUnitUpkeepLimit()
        {
            Army geileArmy3 = new Army();
            geileArmy3.Add(new KillerMachine());
            Assert.False(geileArmy3.Add(new KillerMachine()));
        }
        

        [Test]
        public void TestResolveCasualties()
        {
            Army geileArmy4 = new Army();
            geileArmy4.Add(new Gunner());
            geileArmy4.Add(new Gunner());
            geileArmy4.Add(new Gunner());
            geileArmy4.Add(new Gunner());
            geileArmy4.Add(new Gunner());
            int superCount1 = geileArmy4.SamuraiUnits.Count + geileArmy4.AshigaruUnits.Count;
            geileArmy4.ResolveCasualties(3);
            int superCount2 = geileArmy4.SamuraiUnits.Count + geileArmy4.AshigaruUnits.Count;
            Assert.True(superCount1 > superCount2);
        }
    }
}