using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_DataSecurity_DataEncoding_EncryptionDecryption
{
    internal class BinaryConverter
    {
        /**
         * 
         * Method to convert string to binary.
         * 
         * fullName - full name of the user - input parameter.
         * 
         * Retruns a string - binary value of full name.
         * 
         */
        public static string ConvertStringToBinary(string fullName)
        {
            /**
             * Initiated the value of binaryValueOfFullName as string.Empty ("").
             */
            string binaryValueOfFullName = string.Empty;

            /**
             * Initiated the value of i as 0.
             */
            int i = 0;

            /**
             * 
             * Converting every character in the fullName to its Binary value and appending it to the binaryValueOfFullName.
             * 
             * Looping through the fullName till i is less than the length of fullName.
             * 
             */
            while (i < fullName.Length)
            {
                /**
                 * Getting the charact at the i'th index and assigning it to charAtIndex.
                 */
                char charAtIndex = fullName[i];

                /**
                 * Getting the ASCII value of the charAtIndex and assigning it to asciiValueOfChar.
                 */
                int asciiValueOfChar = (int) charAtIndex;

                /**
                 * Initiated the value of binaryValueOfChar as string.Empty ("").
                 */
                string binaryValueOfChar = "";

                /**
                 * 
                 * Converting asciiValueOfChar to Binary.
                 * 
                 * Dividing asciiValueOfChar by 2 after each iteration.
                 * 
                 * Loop continues unless and until asciiValueOfChar is greater than 0.
                 * 
                 */
                for (; asciiValueOfChar > 0; asciiValueOfChar /= 2)
                {
                    /**
                     * 
                     * Find the reminder of asciiValueOfChar divided by 2.
                     * 
                     * Appending the value to the begining of the binaryValueOfChar.
                     * 
                     */
                    binaryValueOfChar = (asciiValueOfChar % 2) + binaryValueOfChar;
                }

                /**
                 * 
                 * Length of Binary value of each character should be 8.
                 * 
                 * So if the length of binaryValueOfChar is less than 8, we append '0' at the begining of binaryValueOfChar.
                 * 
                 * Loop continues until length of binaryValueOfChar is less than 8.
                 * 
                 */
                while (binaryValueOfChar.Length < 8)
                {
                    /**
                     * Appending '0' at the begining of binaryValueOfChar.
                     */
                    binaryValueOfChar = "0" + binaryValueOfChar;
                }

                /**
                 * 
                 * Maximum length of charAtIndex is 3.
                 * 
                 * To display the ASCII value of all character uniquely, we convert the length of all the ASCII value to 3.
                 * 
                 * If the length of ASCII value of character is less than 3, we append '0' at the begining, so that it doesn't change the value.
                 * 
                 * Assigning it to asciiValueWithThreeChar.
                 * 
                 */
                string asciiValueWithThreeChar = ((int)charAtIndex).ToString().PadLeft(3, '0');

                /**
                 * Displayes the character, its ASCII value and its binary value to the console.
                 */
                Console.WriteLine($"ASCII value for '{charAtIndex}' is {asciiValueWithThreeChar} and its Binary Value is {binaryValueOfChar}");

                /**
                 * Appends the binary value of the character (binaryValueOfChar) to the binary value of string (binaryValueOfFullName).
                 */
                binaryValueOfFullName += binaryValueOfChar;

                /**
                 * Increments i by 1.
                 */
                i++;
            }

            /**
             * Writes a new line to the console.
             */
            Console.WriteLine();

            /**
             * Returns the binary value of fullName (binaryValueOfFullName).
             */
            return binaryValueOfFullName;
        }

        /**
         * 
         * Method to convert binary to string.
         * 
         * binaryString - binary value of full name of the user - input parameter.
         * 
         * Retruns a string - string value of binary - full name.
         * 
         */
        public static string ConvertBinaryToString(string binaryString)
        {
            /**
             * Initiated the value of stringValueOfBinary as string.Empty ("").
             */
            string stringValueOfBinary = string.Empty;

            /**
             * Initialised i as 0.
             */
            int i = 0;

            /**
             * 
             * Converts binary string to string by iterating through the bytes (8 digits) of binaryString.
             * 
             * Increments i by 8 after every iteration.
             * 
             * Loop continues until i is less than the length of binaryString.
             * 
             */
            while (i < binaryString.Length)
            {
                /**
                 * Initialised the value of asciiValueOfChar as 0.
                 */
                int asciiValueOfChar = 0;

                /**
                 * 
                 * Initialised the value of multiplesOfTwo as 1.
                 * 
                 * multiplesOfTwo is the power of 2.
                 * 
                 * It is multiplied by 2 after every iteration while converting binary value of character to ASCII value.
                 * 
                 * When the loop continues to the next character again it is initialised to 1.
                 * 
                 */
                int multiplesOfTwo = 1; // power(2, 0) is 1

                /**
                 * Finding the binary value of character by getting a substring of length 8.
                 */
                string binaryValueOfChar = binaryString.Substring(i, 8);

                /**
                 * Initialising the value of j as the last index of binaryValueOfChar ie., Length of binaryValueOfChar - 1.
                 */
                int j = binaryValueOfChar.Length - 1;

                /**
                 * 
                 * Converts binary value of character to ASCII value.
                 * 
                 * Decrements j by 1 in every iteration.
                 * 
                 * Loop continues until j is greater or equal to 0.
                 * 
                 */
                while (j >= 0)
                {
                    /**
                     * If the value at j'th index of binaryValueOfChar is '1', we add assciiValueOfChar with the multiplesOfTwo.
                     */
                    if (binaryValueOfChar[j] == '1')
                    {
                        /**
                         * Adding assciiValueOfChar with the multiplesOfTwo.
                         */
                        asciiValueOfChar += multiplesOfTwo;
                    }

                    /**
                     * Multiplying multiplesOfTwo with 2, so that it becomes the next power of 2.
                     */
                    multiplesOfTwo *= 2;

                    /**
                     * Decrementing j by 1.
                     */
                    j--;
                }

                /**
                 * 
                 * Maximum length of charAtIndex is 3.
                 * 
                 * To display the ASCII value of all character uniquely, we convert the length of all the ASCII value to 3.
                 * 
                 * If the length of ASCII value of character is less than 3, we append '0' at the begining, so that it doesn't change the value.
                 * 
                 * Assigning it to asciiValueWithThreeChar.
                 * 
                 */
                string asciiValueWithThreeChar = ((int)asciiValueOfChar).ToString().PadLeft(3, '0');

                /**
                 * Finding the character value of the ASCII value and assigning it to the character variable.
                 */
                char character = (char)asciiValueOfChar;

                /**
                 * Displays the binary value of character, ASCII value of character and the character to the console.
                 */
                Console.WriteLine($"ASCII value for {binaryValueOfChar} is {asciiValueWithThreeChar} and its Character value is '{character}'");

                /**
                 * Appends the character to the binary value of string.
                 */
                stringValueOfBinary += character;

                /**
                 * Increments the value of i by 8.
                 */
                i += 8;
            }

            /**
             * Prints a new line to the console.
             */
            Console.WriteLine();

            /**
             * Returns the string value of binary (fullName).
             */
            return stringValueOfBinary;
        }
    }
}
