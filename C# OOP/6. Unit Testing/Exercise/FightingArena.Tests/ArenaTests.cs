namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        private string name = "Petar";

        [Test]
        public void TestCtor()
        {
            Arena testArena = new Arena();

            List<Warrior> collection = testArena.Warriors.ToList();
            List<Warrior> expectdCollection = new List<Warrior>();

            CollectionAssert.AreEqual(expectdCollection, collection,
                "Arena could have an empty collection of warriors");
        }

        [Test]
        public void TestEncapsulationOfWarriors()
        {
            string type = typeof(Arena).GetProperties().First(p => p.Name == "Warriors").PropertyType.Name;
            string expectdType = typeof(IReadOnlyCollection<Warrior>).Name;

            Assert.AreEqual(expectdType, type,
                "current property should be of type IReadOnlyCollection<Warrior>!");
        }

        [Test]
        public void CountReturnsZero_Test()
        {
            Arena arena = new Arena();
            int count = arena.Count;
            int expctCoutn = 0;

            Assert.AreEqual(expctCoutn, count,
                "Count should return zero if there are no Warriors!");
        }

        [Test]
        public void Count_Tester()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 50, 100);
            arena.Enroll(warrior);

            int count = arena.Count;
            int expctCoutn = 1;

            Assert.AreEqual(expctCoutn, count,
                "Count should return the count of the warriors!");
        }

        [Test]
        public void Test_Adder()
        {
            Arena arena = new Arena();
            Warrior petar = new Warrior("Petar", 30, 100);
            Warrior kleko = new Warrior("Kleko", 35, 85);

            arena.Enroll(petar);
            arena.Enroll(kleko);

            List<Warrior> actualCollection = arena.Warriors.ToList();
            List<Warrior> expectedCollection = new List<Warrior>()
            {
                kleko,
                petar
            };

            CollectionAssert.AreEqual(expectedCollection, actualCollection,
                "return warriors");
        }

        [Test]
        public void ShouldThrowException()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Ceko", 50, 100);

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(warrior);
            }, "");
        }

        [Test]
        public void Fight_ThrowException()
        {
            Warrior warrior = new Warrior("Ceko", 50, 100);
            Arena arena = new Arena();
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight("Invalid", "Ceko");
            }, "");
        }

        [Test]
        public void Fight_Test()
        {
            Warrior warrior = new Warrior("Ceko", 50, 100);
            Arena arena = new Arena();
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight("Ceko", "Invalid");
            }, "There is no such fighter");
        }

        [Test]
        public void Fight_Test_Success()
        {
            Warrior Petrovnikov = new Warrior("Petrovnikov", 40, 100);
            Warrior Cvuki = new Warrior("Cvuki", 55, 100);
            Arena arena = new Arena();
            arena.Enroll(Petrovnikov);
            arena.Enroll(Cvuki);

            arena.Fight("Fyre", "Gocata");

            int actualAttackerHp = Petrovnikov.HP;
            int expectedAttackerHp = 100 - Cvuki.Damage;

            int defenderhp = Cvuki.HP;
            int expectdDefHp = 100 - Petrovnikov.Damage;

            Assert.AreEqual(expectedAttackerHp, actualAttackerHp, "should decrease current hp!");
            Assert.AreEqual(expectdDefHp, defenderhp, "should decrease current hp!");
        }
    }
}
