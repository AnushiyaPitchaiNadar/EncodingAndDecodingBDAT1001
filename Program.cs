using Assignment_1_DataSecurity_DataEncoding_EncryptionDecryption;
using System.Data.Common;



Console.WriteLine("----- Task 1: Get full name from user through console -----\n");

/**
 * Writes "Please enter your full name: " to the Console.
 */
Console.Write("Please enter your full name: ");

/**
 * Reads a line from Console and sets the value to fullName.
 */
string fullName = Console.ReadLine();

/**
 * Writes Full Name to the console.
 */
Console.WriteLine("\nYour full name is {0}", fullName);



Console.WriteLine("\n\n\n\n----- Task 2: Binary Encoding and Decoding of full name -----\n");

/**
 * Writes Full Name to the console.
 */
Console.WriteLine("Your full name is {0}\n", fullName);

/**
 * Calls ConvertStringToBinary method in BinaryConverter.cs
 */
string binaryValue = BinaryConverter.ConvertStringToBinary(fullName);

/**
 * Displays thhe Binary value of full name to the console.
 */
Console.WriteLine("Encoded Binary value of {0} is {1}\n\n", fullName, binaryValue);

/**
 * Calls ConvertBinaryToString in BinaryConverter.cs
 * Displays the String value of Binary (full name) in the console.
 */
Console.WriteLine("Decoded String value of {0} is {1}\n", binaryValue, BinaryConverter.ConvertBinaryToString(binaryValue));



Console.WriteLine("\n\n\n\n----- Task 3: Hexadecimal Encoding and Decoding of full name -----\n");

/**
 * Writes Full Name to the console.
 */
Console.WriteLine("Your full name is {0}\n", fullName);

/**
 * Calls ConvertStringToHexadecimal method in HexadecimalConverter.cs
 */
string hexadecimalValue = HexadecimalConverter.ConvertStringToHexadecimal(fullName);
/**
 * Displays the Hexadecimal value of full name in the console.
 */
Console.WriteLine("Encoded Hexadecimal value of {0} is {1}\n\n", fullName, hexadecimalValue);

/**
 * Calls ConvertHexadecimalToString in HexadecimalConverter.cs
 * Displays the String value of Hexadecimal (full name) in the console.
 */
Console.WriteLine("Decoded string value of {0} is {1}", hexadecimalValue, HexadecimalConverter.ConvertHexadecimalToString(hexadecimalValue));



Console.WriteLine("\n\n\n\n----- Task 4: Base64 Encoding and Decoding of full name -----\n");

/**
 * Writes Full Name to the console.
 */
Console.WriteLine("Your full name is {0}\n", fullName);

/**
 * Calls ConvertStringToBase64 method in Base64Converter.cs
 */
string base64Value = Base64Converter.ConvertStringToBase64(fullName);

/**
 * Displays the Base64 value of full name to the console.
 */
Console.WriteLine("Encoded Base64 value of {0} is {1}\n\n", fullName, base64Value);

Console.WriteLine("Decoded string value of {0} is {1}", base64Value, Base64Converter.ConvertBase64ToString(base64Value));



Console.WriteLine("\n\n\n\n----- Task 5: Transposition Cipher Encryption and Decryption of full name -----\n");

/**
 * Writes Full Name to the console.
 */
Console.WriteLine("Your full name is {0}\n", fullName);

/**
 * Calls encryptString method in EncryptDecrypt.cs
 */
string encryptedString = EncryptDecrypt.encryptString(fullName);

/**
 * Displays the encrypted value of full name to the console.
 */
Console.WriteLine("\nTransposition Cipher Encrypted string for {0} is {1}\n\n", fullName, encryptedString);

/**
 * Calls decryptString method in EncryptDecrypt.cs
 */
string decryptedString = EncryptDecrypt.decryptString(encryptedString);

/**
 * Displays the decrypted value of full name to the console.
 */
Console.WriteLine("\nTransposition Cipher Decrypted string for {0} is {1}", encryptedString, decryptedString);
