using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_DataSecurity_DataEncoding_EncryptionDecryption
{
    internal class Base64Converter
    {

        /**
         * 
         * Converts String to base64.
         * 
         * fullName - full name of the user - input parameter.
         * 
         * Retruns a string - base64 value of full name.
         * 
         */
        public static string ConvertStringToBase64(string fullName)
        {
            /**
             * 
             * These are the base64 values of 0 to 15.
             * 
             * Values are put into an array and assigned to base64Characters.
             * 
             */
            string base64Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

            /**
             * Initialised base64ValueOfString as string.Empty ("").
             */
            string base64ValueOfString = string.Empty;

            /**
             * 
             * Calls ConvertStringToBinary in BinaryConverter.cs
             * 
             * ConvertStringToBinary returns the binary string of fullName
             * 
             * binaryValueOfString is assigned with the binary string value.
             * 
             */
            string binaryValueOfString = BinaryConverter.ConvertStringToBinary(fullName);

            /**
             * Length of binaryValueOfString is assigned to lengthOfBinaryString.
             */
            int lengthOfBinaryString = binaryValueOfString.Length;

            /**
             * Declared variables - zeroPadding and equalsPadding
             */
            string zeroPadding, equalsPadding;

            /**
             * 
             * If lengthOfBinaryString is a multiple of 3, we don't need any padding. 
             * So we assign string.Empty ("") to zeroPadding and equalsPadding.
             * 
             * If the reminder is 1 when we divide lengthOfBinaryString by 3, 
             * we add "00" to the end of binary string and "=" at the end of base64 string.
             * 
             * If the reminder is 2 when we divide lengthOfBinaryString by 3, 
             * we add "0000" to the end of binary string and "==" at the end of base64 string.
             * 
             */
            if (lengthOfBinaryString % 3 == 1)
            {
                /**
                 * Assigning "00" to zeroPadding.
                 */
                zeroPadding = "00";

                /**
                 * Assigning "=" to equalsPadding.
                 */
                equalsPadding = "=";
            }
            else if (lengthOfBinaryString % 3 == 2)
            {
                /**
                 * Assigning "0000" to zeroPadding.
                 */
                zeroPadding = "0000";

                /**
                 * Assigning "==" to equalsPadding.
                 */
                equalsPadding = "==";
            }
            else
            {
                /**
                 * Assigning string.Empty ("") to zeroPadding.
                 */
                zeroPadding = string.Empty;

                /**
                 * Assigning string.Empty ("") to equalsPadding.
                 */
                equalsPadding = string.Empty;
            }

            /**
             * Appending zeroPadding to binaryValueOfString.
             */
            binaryValueOfString += zeroPadding;

            /**
             * 
             * Converts binary string to base64 string.
             * 
             * Loop continues from i = 0 to binaryValueOfString.Length - 6
             * 
             * After each iteration i is incremented by 6.
             * 
             */
            for (int i = 0; i <= binaryValueOfString.Length - 6; i += 6)
            {
                /**
                 * Gets the substring of base64ValueOfString from i with length 6 and assigns it to sixBitString.
                 */
                string sixBitString = binaryValueOfString.Substring(i, 6);

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
                 * Assigned 0 to decimalValueOfSixBits.
                 */
                int decimalValueOfSixBits = 0;

                /**
                 * Initialising the value of j as the last index of sixBitString ie., Length of sixBitString - 1.
                 */
                int j = sixBitString.Length - 1;

                /**
                 * 
                 * Converts binary value of character to decimal value.
                 * 
                 * Decrements j by 1 in every iteration.
                 * 
                 * Loop continues until j is greater or equal to 0.
                 * 
                 */
                while (j >= 0)
                {
                    /**
                     * If the value at j'th index of sixBitString is '1', we add decimalValueOfSixBits with the multiplesOfTwo.
                     */
                    if (sixBitString[j] == '1')
                    {
                        /**
                         * Adding decimalValueOfSixBits with the multiplesOfTwo.
                         */
                        decimalValueOfSixBits += multiplesOfTwo;
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
                base64ValueOfString += base64Characters[decimalValueOfSixBits];
            }

            /**
             * Appending equalsPadding to base64ValueOfString.
             */
            base64ValueOfString += equalsPadding;

            /**
             * Returning base64ValueOfString.
             */
            return base64ValueOfString;
        }


        /**
         * 
         * Converts Base64 to String.
         * 
         * base64ValueOfFullName - base64 value of full name of the user - input parameter.
         * 
         * Retruns a string - string value of base64 - full name.
         * 
         */
        public static string ConvertBase64ToString(String base64ValueOfFullName)
        {
            /**
             * 
             * These are the base64 values of 0 to 15.
             * 
             * Values are put into an array and assigned to base64Characters.
             * 
             */
            string base64Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

            /**
             * Initialised binaryValueOfFullName as string.Empty ("").
             */
            string binaryValueOfFullName = string.Empty;

            /**
             * Initialised paddingCount as 0.
             */
            int paddingCount = 0;

            /**
             * Initialised i as the last index of base64ValueOfFullName ie., Length of base64ValueOfFullName - 1..
             */
            int i = base64ValueOfFullName.Length - 1;

            /**
             * 
             * We have to find the number of padding we used to convert string to base64.
             * 
             * It can be found using the number of '=' at the end of base64 string.
             * 
             * Loop continues until i is greated than 0 and the last index of base64ValueOfFullName contains '='.
             * 
             */
            while (i >= 0 && base64ValueOfFullName[i] == '=')
            {
                /**
                 * Incrementing paddingCount by 1.
                 */
                paddingCount++;

                /**
                 * Decrementing i by 1.
                 */
                i--;
            }

            /**
             * Removing all the '=' at the end of base64ValueOfFullName using TrimEnd function.
             */
            base64ValueOfFullName = base64ValueOfFullName.TrimEnd('=');

            /**
             * Converts base64ValueOfFullName to binary.
             */
            foreach (char c in base64ValueOfFullName)
            {
                /**
                 * Gets the index of the character c in base64Characters and assigns it to base64.
                 */
                int base64 = base64Characters.IndexOf(c);

                /**
                 * Initiated the value of binaryValueOfChar as string.Empty ("").
                 */
                string binaryValueOfChar = string.Empty;

                /**
                 * 
                 * Converting base64 to Binary.
                 * 
                 * Dividing base64 by 2 after each iteration.
                 * 
                 * Loop continues unless and until asciiValueOfChar is greater than 0.
                 * 
                 */
                for (; base64 > 0; base64 /= 2)
                {
                    /**
                     * 
                     * Find the reminder of asciiValueOfChar divided by 2.
                     * 
                     * Appending the value to the begining of the binaryValueOfChar.
                     * 
                     */
                    binaryValueOfChar = (base64 % 2) + binaryValueOfChar;
                }

                /**
                 * 
                 * Length of Binary value of each character should be 6.
                 * 
                 * So if the length of binaryValueOfChar is less than 6, we append '0' at the begining of binaryValueOfChar.
                 * 
                 * Loop continues until length of binaryValueOfChar is less than .6
                 * 
                 */
                while (binaryValueOfChar.Length < 6)
                {
                    /**
                     * Appending '0' at the begining of binaryValueOfChar.
                     */
                    binaryValueOfChar = "0" + binaryValueOfChar;
                }

                /**
                 * Appends binaryValueOfChar to binaryValueOfFullName;
                 */
                binaryValueOfFullName += binaryValueOfChar;

            }

            /**
             * 
             * If paddingCount is greater than 0, we have to remove those extra "00" added while encoding at the end of binary string.
             * 
             * So we remove '0' twice the padding count from the end of binary string by getting the substring.
             * 
             */
            if (paddingCount > 0 )
            {
                /**
                 * Removing '0' twice the padding count from the end of binary string by getting the substring.
                 */
                binaryValueOfFullName = binaryValueOfFullName.Substring(0, binaryValueOfFullName.Length - paddingCount * 2);
            }

            /**
             * 
             * Calls ConvertBinaryToString method in BinaryConverter.cs. It returns the string value of binary
             * 
             * Returns the string.
             * 
             */
            return BinaryConverter.ConvertBinaryToString(binaryValueOfFullName);
        }
    }
}
