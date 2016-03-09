using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption_practical;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Rot13_encryptAString_encryptedString()
        {
            ROT13Encryt encryptmachine = new ROT13Encryt();

            String plaintext = "Richard Horne";
            String expectedtext = "Evpuneq Ubear";
            String resulttext = encryptmachine.EncryptDecrypt(plaintext);

            Assert.AreEqual(expectedtext, resulttext);
        }

        [TestMethod]
        public void ReverseEncrypt_encryptAString_encryptedString()
        {
            ReverseEncrption encryptmachine = new ReverseEncrption();

            String plaintext = "Richard Horne";
            String expectedtext = "enroH drahciR";
            String resulttext = encryptmachine.EncryptDecrypt(plaintext);

            Assert.AreEqual(expectedtext, resulttext);
        }
    }
}
