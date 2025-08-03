


using System;
using Net.Pkcs11Admin;

class TestRunner
{
    static void Main()
    {
        Console.WriteLine("Testing Utils.ByteArrayToHexString...");

        // Test empty string
        string result1 = Utils.ByteArrayToHexString(new byte[0]);
        Console.WriteLine($"Empty array: \"{result1}\" (expected: \"\")");
        Console.WriteLine(result1 == "" ? "PASS" : "FAIL");

        // Test single byte
        string result2 = Utils.ByteArrayToHexString(new byte[] { 1 });
        Console.WriteLine($"Single byte: \"{result2}\" (expected: \"01\")");
        Console.WriteLine(result2 == "01" ? "PASS" : "FAIL");

        // Test multiple bytes
        string result3 = Utils.ByteArrayToHexString(new byte[] { 1, 2, 3, 4 });
        Console.WriteLine($"Multiple bytes: \"{result3}\" (expected: \"01020304\")");
        Console.WriteLine(result3 == "01020304" ? "PASS" : "FAIL");

        Console.WriteLine("\nTesting Utils.HexStringToByteArray...");

        // Test empty string
        byte[] result4 = Utils.HexStringToByteArray("");
        Console.WriteLine($"Empty string: {string.Join(", ", result4)} (expected: [])");
        Console.WriteLine(result4.Length == 0 ? "PASS" : "FAIL");

        // Test single byte
        byte[] result5 = Utils.HexStringToByteArray("01");
        Console.WriteLine($"Single byte: {string.Join(", ", result5)} (expected: [1])");
        Console.WriteLine(result5.Length == 1 && result5[0] == 1 ? "PASS" : "FAIL");

        // Test multiple bytes
        byte[] result6 = Utils.HexStringToByteArray("01020304");
        Console.WriteLine($"Multiple bytes: {string.Join(", ", result6)} (expected: [1, 2, 3, 4])");
        Console.WriteLine(result6.Length == 4 && result6[0] == 1 && result6[1] == 2 && result6[2] == 3 && result6[3] == 4 ? "PASS" : "FAIL");

        Console.WriteLine("\nAll tests completed!");
    }
}


