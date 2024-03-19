namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System.Reflection;
    using System;
    using System.Linq;

    [TestFixture]
    public class WarriorTests
    {
        [Test]
        public void Test_Ctor()
        {
            string Name = "Petar";
            int dmg = 55;
            int hp = 33;

            Warrior warrior = new Warrior(Name, dmg, hp);

            FieldInfo nameField = this.GetField("name");
            string actualName = (string)nameField.GetValue(warrior);

            FieldInfo damageField = this.GetField("damage");
            int actualDamage = (int)damageField.GetValue(warrior);

            FieldInfo hpField = this.GetField("hp");
            int actualHp = (int)hpField.GetValue(warrior);

            Assert.AreEqual(Name, actualName,
                "Constructor should have the Name of the Warrior!");
            Assert.AreEqual(dmg, actualDamage,
                "Constructor should have the Damage of the Warrior!");
            Assert.AreEqual(hp, actualHp,
                "Constructor should have the HP of the Warrior!");
        }

        [Test]
        public void TestNameGetter()
        {
            string name = "Petar";
            Warrior warrior = new Warrior(name, 55, 33);

            string actualName = warrior.Name;

            Assert.AreEqual(name, actualName,
                "getter should return value!");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("        ")]
        public void testSetter(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, 55, 55);
            }, "Name should not be empty or whitespace!");
        }

        [Test]
        public void testDMGGetter()
        {
            int dmg = 55;
            Warrior warrior = new Warrior("Petar", dmg, 33);

            int actDMG = warrior.Damage;

            Assert.AreEqual(dmg, actDMG,
                "getter should return value!");
        }

        [TestCase(-4)]
        [TestCase(-2)]
        [TestCase(0)]
        public void testDMGSetterValidator(int damage)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Petar", damage, 55);
            }, "Damage should be positive!");
        }

        [Test]
        public void TestHP_Getter()
        {
            int hp = 55;
            Warrior warrior = new Warrior("Petar", 33, hp);

            int actualHP = warrior.HP;

            Assert.AreEqual(hp, actualHP,
                "getter should return value of hp");
        }

        [TestCase(-3)]
        [TestCase(-2)]
        public void TestHPSetterValidation(int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Petar", 55, hp);
            }, "HP shouldn't be negative!");
        }

        [TestCase(0)]
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(25)]
        public void AttackErrors_Test(int startHP)
        {
            Warrior patrona = new Warrior("Patrona", 70, startHP);
            Warrior petar = new Warrior("Petar", 55, 45);

            Assert.Throws<InvalidOperationException>(() =>
            {
                patrona.Attack(petar);
            }, "");
        }

        [TestCase(0)]
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(25)]
        public void AttaackError(int startHP)
        {
            Warrior cvuki = new Warrior("Cvuki", 45, 65);
            Warrior petar = new Warrior("Petar", 35, startHP);

            Assert.Throws<InvalidOperationException>(() =>
            {
                us.Attack(petar);
            }, "");
        }

        [TestCase(50, 60)]
        [TestCase(50, 51)]
        public void attack1(int attackerHp, int defenderDamage)
        {
            Warrior ceko =  new Warrior("Ceko", 50, attackerHp);
            Warrior petar = new Warrior("Petar", defenderDamage, 50);

            Assert.Throws<InvalidOperationException>(() =>
            {
                ceko.Attack(petar);
            }, "");
        }

        [TestCase(70, 50)]
        [TestCase(60, 55)]
        [TestCase(60, 60)]
        public void SuccessAttackShouldDecreaseAttackerHP(int attackerHp, int dfdmg)
        {
            Warrior kleko = new Warrior("Kleko", 50, attackerHp);
            Warrior petar = new Warrior("petar", dfdmg, 55);

            kleko.Attack(petar);

            int hp = kleko.HP;
            int exchp = attackerHp - dfdmg;

            Assert.AreEqual(exchp, hp,
                "");
        }

        [TestCase(70, 40)]
        [TestCase(60, 55)]
        [TestCase(60, 59)]
        public void successAttack(int attdmg, int defenderHp)
        {
            Warrior ceko = new Warrior("Ceko", attdmg, 100);
            Warrior petarcho = new Warrior("Petarcho", 40, defenderHp);

            ceko.Attack(petarcho);

            int actualDefenderHp = petarcho.HP;
            int expectedDefenderHp = 0;

            Assert.AreEqual(expectedDefenderHp, actualDefenderHp,
                "");
        }

        [TestCase(50, 100)]
        [TestCase(50, 60)]
        [TestCase(50, 51)]
        [TestCase(50, 50)]
        public void attackError22(int attackerDamage, int defenderHp)
        {
            Warrior fyre = new Warrior("Petar", attackerDamage, 100);
            Warrior us = new Warrior("Ceco", 30, defenderHp);

            fyre.Attack(us);

            int actualDefenderHp = us.HP;
            int expectedDefenderHp = defenderHp - attackerDamage;

            Assert.AreEqual(expectedDefenderHp, actualDefenderHp,
                "");
        }

        private FieldInfo GetField(string fieldName)
            => typeof(Warrior)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == fieldName);
    }
}