using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Character;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToString_CharactedThatsDefaultInstationtion_returnsTostringWithDefaultWeapon()
        {
            Character testCharacter = new King("Bob");

            String expectedString = "My name is Bob! I am the most mighty King! I slice with my sword!";

            String actualString = testCharacter.ToString();

            Assert.AreEqual(expectedString, actualString);

        }

        [TestMethod]
        public void changeWeapon_changeACharatersWeapong_returnsTNewWeaponUseWeaponString()
        {
            Character testCharacter = new King("Bob");

            testCharacter.weapon = new Bow();

            String expectedString = "I shoot with my bow!";

            String actualString = testCharacter.weapon.UseWeapon();

            Assert.AreEqual(expectedString, actualString);

        }
    }
}
