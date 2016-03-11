using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Character;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToStringKing_CharactedThatsDefaultInstationtion_returnsTostringWithDefaultWeapon()
        {
            Character testCharacter = new King("Bob");

            String expectedString = "My name is Bob! I am the most mighty King! I slice with my sword!";

            String actualString = testCharacter.ToString();

            Assert.AreEqual(expectedString, actualString);

        }


        [TestMethod]
        public void ToStringQueen_CharactedThatsDefaultInstationtion_returnsTostringWithDefaultWeapon()
        {
            Character testCharacter = new Queen("Bob");

            String expectedString = "My name is Bob! I am the powerful Queen! I shoot with my bow!";

            String actualString = testCharacter.ToString();

            Assert.AreEqual(expectedString, actualString);

        }


        [TestMethod]
        public void ToStringTroll_CharactedThatsDefaultInstationtion_returnsTostringWithDefaultWeapon()
        {
            Character testCharacter = new Troll("Bob");

            String expectedString = "My name is Bob! Trolls don't have time to chat! I shoot with my bow!";

            String actualString = testCharacter.ToString();

            Assert.AreEqual(expectedString, actualString);

        }

        [TestMethod]
        public void ToStringKnight_CharactedThatsDefaultInstationtion_returnsTostringWithDefaultWeapon()
        {
            Character testCharacter = new Knight("Bob");

            String expectedString = "My name is Bob! I am a chivalrous Knight! I Stab with my knife!";

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
