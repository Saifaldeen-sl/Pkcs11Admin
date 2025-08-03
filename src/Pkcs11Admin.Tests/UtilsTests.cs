

using Microsoft.VisualStudio.TestTools.UnitTestFramework;
using Net.Pkcs11Admin;

namespace Pkcs11Admin.Tests
{
    [TestClass]
    public class UtilsTests
    {
        [TestMethod]
        public void TestHexStringConversion()
        {
            // Test empty string
            Assert.AreEqual("", Utils.ByteArrayToHexString(new byte[0]));

            // Test single byte
            Assert.AreEqual("01", Utils.ByteArrayToHexString(new byte[] { 1 }));

            // Test multiple bytes
            Assert.AreEqual("01020304", Utils.ByteArrayToHexString(new byte[] { 1, 2, 3, 4 }));

            // Test with zero values
            Assert.AreEqual("00010200", Utils.ByteArrayToHexString(new byte[] { 0, 1, 2, 0 }));
        }

        [TestMethod]
        public void TestHexStringToByteArray()
        {
            // Test empty string
            CollectionAssert.AreEqual(new byte[0], Utils.HexStringToByteArray(""));

            // Test single byte
            CollectionAssert.AreEqual(new byte[] { 1 }, Utils.HexStringToByteArray("01"));

            // Test multiple bytes
            CollectionAssert.AreEqual(new byte[] { 1, 2, 3, 4 }, Utils.HexStringToByteArray("01020304"));

            // Test with zero values
            CollectionAssert.AreEqual(new byte[] { 0, 1, 2, 0 }, Utils.HexStringToByteArray("00010200"));
        }

        [TestMethod]
        public void TestHexStringToByteArray_InvalidInput()
        {
            // Test odd length string (should throw)
            Assert.ThrowsException<System.FormatException>(() => Utils.HexStringToByteArray("1"));
            Assert.ThrowsException<System.FormatException>(() => Utils.HexStringToByteArray("123"));

            // Test invalid characters
            Assert.ThrowsException<System.FormatException>(() => Utils.HexStringToByteArray("GG01"));
            Assert.ThrowsException<System.FormatException>(() => Utils.HexStringToByteArray("01GH"));
        }
    }
}


