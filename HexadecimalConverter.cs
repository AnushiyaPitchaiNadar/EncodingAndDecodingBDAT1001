using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_DataSecurity_DataEncoding_EncryptionDecryption
{
    internal class HexadecimalConverter
    {

        /**
         * 
         * Converts String to Hexadecimal.
         * 
         * fullName - full name of the user - input parameter.
         * 
         * Retruns a string - hexadecimal value of full name.
         * 
         */
        public static string ConvertStringToHexadecimal(string fullName)
        {
            /**
             * Initialised hexadecimalValueOfFullName as string.Empty ("").
             */
            string hexadecimalValueOfFullName = string.Empty;

            /**
             * 
             * These are the hexadecimal values of 0 to 15.
             * 
             * Values are put into an array and assigned to hexadecimalValues.
             * 
             */
            char[] hexadecimalValues = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];

            /**
             * Initialised i as 0.
             */
            int i = 0;

            /**
             * 
             * Converts fullName to hexadecimal.
             * 
             * Loop continues until i is less than the length of fullName.
             * 
             * Increments i by 1 after each iteration.
             */
            while (i < fullName.Length)
            {
                /**
                 * Initialised charAtIndex as the character at the i'th index of fullName.
                 */
                char charAtIndex = fullName[i];

                /**
                 * Assigned the interger value (ASCII value) of charAtIndex to asciiValueOfChar.
                 */
                int asciiValueOfChar = (int)charAtIndex;

                /**
                 * Initialised hexadecimalValueOfChar as string.Empty ("").
                 */
                string hexadecimalValueOfChar = "";

                /**
                 * 
                 * Converting asciiValueOfChar to Hexadecimal.
                 * 
                 * Dividing asciiValueOfChar by 16 after each iteration.
                 * 
                 * Loop continues unless and until asciiValueOfChar is greater than 0.
                 * 
                 */
                for (; asciiValueOfChar > 0; asciiValueOfChar /= 16)
                {
                    /**
                     * 
                     * Find the reminder of asciiValueOfChar divided by 16.
                     * 
                     * Value ranges from 0 to 15
                     * 
                     */
                    int hexadecimalValue = asciiValueOfChar % 16;

                    /**
                     * 
                     * Getting the hexadecimal value of hexadecimalValue from hexadecimalValues array using hexadecimalValue as the index.
                     * 
                     * Appending the value at the begining of hexadecimalValueOfChar.
                     * 
                     */
                    hexadecimalValueOfChar = hexadecimalValues[hexadecimalValue] + hexadecimalValueOfChar;
                }

                /**
                 * 
                 * Length of hexadecimalValueOfChar should be 2.
                 * 
                 * If the length is less than 2, we append '0' at the begining of hexadecimalValueOfChar so that the value doesn't change.
                 * 
                 */
                if (hexadecimalValueOfChar.Length < 2)
                {
                    /**
                     * Appending '0' at the beginning of hexadecimalValueOfChar.
                     */
                    hexadecimalValueOfChar = "0" + hexadecimalValueOfChar;
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
                 * Displayes the character, its ASCII value and its hexadecimal value to the console.
                 */
                Console.WriteLine($"ASCII value for '{charAtIndex}' is {asciiValueWithThreeChar} and its Hexadecimal Value is {hexadecimalValueOfChar}");

                /**
                 * Appends the hexadecimal value of the character (hexadecimalValueOfChar) to the hexadecimal value of string (hexadecimalValueOfFullName).
                 */
                hexadecimalValueOfFullName += hexadecimalValueOfChar;

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
             * Returns the hexadecimal value of fullName (hexadecimalValueOfFullName).
             */
            return hexadecimalValueOfFullName;
        }

        /**
         * 
         * Method to convert hexadecimal to string.
         * 
         * hexadecimalString - hexadecimal value of full name of the user - input parameter.
         * 
         * Retruns a string - string value of hexadecimal - full name.
         * 
         */
        public static string ConvertHexadecimalToString(string hexadecimalString)
        {
            /**
             * Initialised stringValue as string.Empty ("").
             */
            string stringValue = string.Empty;

            /**
             * 
             * These are the hexadecimal values of 0 to 15.
             * 
             * Values are put into an array and assigned to hexadecimalValues.
             * 
             */
            char[] hexadecimalValues = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];

            /**
             * Initialised i as 0.
             */
            int i = 0;

            /**
             * 
             * Converts Hexadecimal to string.
             * 
             * Loop continues until i is less than the length of hexadecimalString.
             * 
             * Increments i by 2 after each iteration.
             * 
             */
            while (i < hexadecimalString.Length)
            {
                /**
                 * 
                 * Getting the index of hexadecimal at i'th index of hexadecimalValues and multiplying it with  16.
                 * 
                 * Getting the index of hexadecimal at (i+1)'th index of hexadecimalValues.
                 * 
                 * Adding both the values to get the ASCII value of character.
                 * 
                 */
                int asciiValueOfChar = (16 * hexadecimalValues.ToList().IndexOf(hexadecimalString[i])) + hexadecimalValues.ToList().IndexOf(hexadecimalString[i + 1]);

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
                char character = (char) asciiValueOfChar;

                /**
                 * Displays the hexadecimal value of character, ASCII value of character and the character to the console.
                 */
                Console.WriteLine($"ASCII value for {hexadecimalString.Substring(i, 2)} is {asciiValueWithThreeChar} and its Character value is '{character}'");

                /**
                 * Appends the character to stringValue.
                 */
                stringValue += character;

                /**
                 * Increments the value of i by 2.
                 */
                i += 2;
            }

            /**
             * Prints a new line to the console.
             */
            Console.WriteLine();

            /**
             * Returns the string value of hexadecimalString (fullName).
             */
            return stringValue;
        }

    }
}
