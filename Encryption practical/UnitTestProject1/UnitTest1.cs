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


        [TestMethod]
        public void ReverseEncrypt_encryptAStringAndNumbers_encryptedString()
        {
            ReverseEncrption encryptmachine = new ReverseEncrption();

            String plaintext = "Richard 13 Horne 01";
            String expectedtext = "10 enroH 31 drahciR";
            String resulttext = encryptmachine.EncryptDecrypt(plaintext);

            Assert.AreEqual(expectedtext, resulttext);
        }


        [TestMethod]
        public void Rot13_encryptAStringAndNumbers_encryptedString()
        {
            ROT13Encryt encryptmachine = new ROT13Encryt();

            String plaintext = "Richard 13 Horne 01";
            String expectedtext = "Evpuneq 13 Ubear 01";
            String resulttext = encryptmachine.EncryptDecrypt(plaintext);

            Assert.AreEqual(expectedtext, resulttext);
        }

        [TestMethod]
        public void Rot13_DecryptAStringAndNumbers_encryptedString()
        {
            ROT13Encryt encryptmachine = new ROT13Encryt();

            String encyptedText = "Evpuneq 13 Ubear 01";
            String expectedtext = "Richard 13 Horne 01";
            String resulttext = encryptmachine.EncryptDecrypt(encyptedText);

            Assert.AreEqual(expectedtext, resulttext);
        }

    }
}
