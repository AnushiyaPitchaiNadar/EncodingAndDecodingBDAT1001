using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_DataSecurity_DataEncoding_EncryptionDecryption
{
    internal class EncryptDecrypt
    {
        /**
         * 
         * Converts string to Matrix.
         * 
         * fullName - full name of the user - input parameter.
         * 
         * Returns char[,] - 2 Dimensional character array - Matrix.
         * 
         */
        static char[,] convertStringToMatrix(string fullName)
        {
            /**
             * Assumption: Length of key is 6.
             * 
             * Assigning 6 to numberOfColumns, since length of key is 6.
             */
            int numberOfColumns = 6;

            /**
             * Getting the quotient of Length of fullName divided by 6 and assigning it to numberOfRows.
             */
            int numberOfRows = fullName.Length / 6;

            /**
             * If there are any reminders, we should have one more row to accomodate all the characters in string.
             */
            if (fullName.Length % 6 != 0)
            {
                /**
                 * Reminder is not 0, so we add one more row. So incrementing the numberOfRows.
                 */
                numberOfRows++;
            }

            /**
             * Initiated stringIndex as 0.
             */
            int stringIndex = 0;

            /**
             * Creating a 2 dimensional array called nameMatrix and specifying the number of rows and columns.
             */
            char[,] nameMatrix = new char[numberOfRows, numberOfColumns];

            /**
             * Iterating through the Matrix and assigning values from fullName.
             */
            for (int i = 0; i < numberOfRows; i++)
            {
                /**
                 * Assigned 0 to j.
                 */
                int j = 0;

                /**
                 * 
                 * Assigning values to the matrix.
                 * 
                 * Loop continues until j is less than numberOfColumns and stringIndex is less than the length of fullName.
                 * 
                 * Increments j by 1 after each iteration.
                 * 
                 */
                for (; j < numberOfColumns && stringIndex < fullName.Length; j++)
                {
                    /**
                     * Assigns the value at stringIndex of fullName to nameMatrix i'th row and j'th column.
                     */
                    nameMatrix[i, j] = fullName[stringIndex];

                    /**
                     * Increments stringIndex by 1.
                     */
                    stringIndex++;
                }

                /**
                 * I'm assigning ' ' to all other remaining cells in the matrix. So that while printing the matrix, it is in order.
                 */
                if (stringIndex >= fullName.Length)
                {
                    /**
                     * Iterated through matrix and assigns ' ' to remaining cells.
                     */
                    for (; j < numberOfColumns; j++)
                    {
                        /**
                         * Assigns ' ' to remaining cells.
                         */
                        nameMatrix[i, j] = ' ';
                    }
                }
            }
            /**
             * Returns nameMatrix.
             */
            return nameMatrix;
        }

        /**
         * 
         * Converts matrix to String.
         * 
         * Takes matrix of type char[,] as input.
         * 
         * Returns string.
         * 
         */
        static string convertMatrixToString(char[,] matrix)
        {
            /**
             * Initiated the value of stringValue as string.Empty ("").
             */
            string stringValue = string.Empty;

            /**
             * Gets the length of 0th index in matrix and assigns to numberOfRows.
             */
            int numberOfRows = matrix.GetLength(0);

            /**
             * Gets the length of 1st index in matrix and assigns to numberOfColumns.
             */
            int numberOfColumns = matrix.GetLength(1);

            /**
             * 
             * Iterates through the rows of matrix.
             * 
             * Loop continues until i is less than numberOfRows.
             * 
             * After each iteration i is incremented by 1.
             * 
             */
            for (int i = 0; i < numberOfRows; i++)
            {
                /**
                 * 
                 * Iterates through the columns of matrix.
                 * 
                 * Loop continues until j is less than numberOfColumns.
                 * 
                 * After each iteration j is incremented by 1.
                 * 
                 */
                for (int j = 0; j < numberOfColumns; j++)
                {
                    /**
                     * Appends the value of cell to stringValue.
                     */
                    stringValue += matrix[i, j];
                }
            }
            /**
             * Returns stringValue.
             */
            return stringValue;
        }

        /**
         * 
         * Prints matrix in rows and columns.
         * 
         * Takes matrix of type char[,] as input.
         * 
         */
        static void printMatrix(char[,] matrix)
        {
            /**
             * Gets the length of 0th index in matrix and assigns to numberOfRows.
             */
            int numberOfRows = matrix.GetLength(0);

            /**
             * Gets the length of 1st index in matrix and assigns to numberOfColumns.
             */
            int numberOfColumns = matrix.GetLength(1);

            /**
             * Writes space needed before index to the console.
             */
            Console.Write("  ");

            /**
            * 
            * Prints the index.
            * 
            * Loop contines until j is less than numberOfColumns.
            * 
            * j is incremented by 1 after each iteration.
            * 
            */
            for (int j = 0; j < numberOfColumns; j++)
            {
                /**
                 * Writes the value of j and a space to the console.
                 */
                Console.Write(j + " ");
            }

            /**
             * Writes new line to the console.
             */
            Console.WriteLine();

            /**
             * 
             * Iterates through the matrix and prints all values.
             * 
             * Loop continues until i is less than numberOfRows.
             * 
             * i is incremented by 1 after each iteration.
             * 
             */
            for (int i = 0; i < numberOfRows; i++)
            {
                /**
                 * Writes the value of i (row index) to the console.
                 */
                Console.Write(i + " ");

                /**
                 *  
                 * Iterates through the matrix and prints all values.
                 * 
                 * Loop continues until j is less than numberOfColumns.
                 * 
                 * j is incremented by 1 after each iteration.
                 * 
                 */
                for (int j = 0; j < numberOfColumns; j++)
                {
                    /**
                     * Writes the values of cell at ith column jth row in matrix to the console.
                     */
                    Console.Write(matrix[i, j] + " ");
                }

                /**
                 * Writes a new line to the console.
                 */
                Console.WriteLine();
            }
        }

        /**
         * 
         * Transpositions the matrix.
         * 
         * Takes char[,] as input.
         * 
         * Returns char[,].
         * 
         */
        static char[,] TransposeMatrix(char[,] nameMatrix)
        {
            /**
             * Assigning the value of key.
             */
            string key = "421035";

            /**
             * Gets the length of 0th index in matrix and assigns to numberOfRows.
             */
            int numberOfRows = nameMatrix.GetLength(0);

            /**
             * Gets the length of 1st index in matrix and assigns to numberOfColumns.
             */
            int numberOfColumns = nameMatrix.GetLength(1);

            /**
             * Creating a 2 dimensional array called nameMatrix and specifying the number of rows and columns.
             */
            char[,] transposedMatrix = new char[numberOfRows, numberOfColumns];

            /**
             * 
             * Iterates through the columns of the matrix and transposes the matrix.
             * 
             * Loop continues until column is less than numberOfColumns.
             * 
             * column is incremented by 1 after every iteration.
             * 
             */
            for (int column = 0; column < numberOfColumns; column++)
            {
                /**
                 * Gets the transpose index from the using the column index.
                 */
                int transposeIndex = int.Parse(key[column].ToString());

                /**
                 * 
                 * Iterates through the rows of the matrix and transposes the matrix.
                 * 
                 * Loop continues until row is less than numberOfRows.
                 * 
                 * row is incremented by 1 after every iteration.
                 * 
                 */
                for (int row = 0; row < numberOfRows; row++)
                {
                    /**
                     * Copies the value of the cell in nameMatrix to the transposedMatrix.
                     */
                    transposedMatrix[row, transposeIndex] = nameMatrix[row, column];
                }
            }

            /**
             * Returns transposedMatrix.
             */
            return transposedMatrix;
        }

        /**
         * 
         * Transpositions the matrix.
         * 
         * Takes char[,] as input.
         * 
         * Returns char[,].
         * 
         */
        static char[,] ReverseTransposeMatrix(char[,] matrix)
        {
            /**
             * Assigning the value of key.
             */
            string key = "421035";

            /**
             * Gets the length of 0th index in matrix and assigns to numberOfRows.
             */
            int numberOfRows = matrix.GetLength(0);

            /**
             * Gets the length of 1st index in matrix and assigns to numberOfColumns.
             */
            int numberOfColumns = matrix.GetLength(1);

            /**
             * Creating a 2 dimensional array called reverseTransposedMatrix and specifying the number of rows and columns.
             */
            char[,] reverseTransposedMatrix = new char[numberOfRows, numberOfColumns];

            /**
             * 
             * Iterates through the columns of the matrix and transposes the matrix.
             * 
             * Loop continues until column is less than numberOfColumns.
             * 
             * column is incremented by 1 after every iteration.
             * 
             */
            for (int column = 0; column < numberOfColumns; column++)
            {
                /**
                 * Gets the transpose index from the using the column index.
                 */
                int transposeIndex = int.Parse(key[column].ToString());

                /**
                * 
                * Iterates through the rows of the matrix and transposes the matrix.
                * 
                * Loop continues until row is less than numberOfRows.
                * 
                * row is incremented by 1 after every iteration.
                * 
                */
                for (int row = 0; row < numberOfRows; row++)
                {
                    /**
                     * Copies the value of the cell in matrix to the reverseTransposedMatrix.
                     */
                    reverseTransposedMatrix[row, column] = matrix[row, transposeIndex];
                }
            }

            /**
             * Returns reverseTransposedMatrix.
             */
            return reverseTransposedMatrix;
        }

        /**
         * 
         * Encrypts ths string based on Transposition Cipher.
         * 
         * fullName - full name of the user - input parameter.
         * 
         * Returns the encrypted string.
         * 
         */
        public static string encryptString(string fullName)
        {
            /**
             * Calls convertStringToMatrix to create the nameMatrix.
             */
            char[,] nameMatrix = convertStringToMatrix(fullName);

            /**
             * Writes the text to the console.
             */
            Console.WriteLine("Full Name in Matrix form: ");

            /**
             * Calls the printMatrix methods and prints the matrix.
             */
            printMatrix(nameMatrix);

            /**
             * Calls TransposeMatrix method and gets the TransposedMatrix.
             */
            char[,] TransposedMatrix = TransposeMatrix(nameMatrix);

            /**
             * Writes the text to the console.
             */
            Console.WriteLine("\nShifted Matrix:");

            /**
             * Calls the printMatrix methods and prints the matrix.
             */
            printMatrix(TransposedMatrix);

            /**
             * Calls convertMatrixToString method and returns the encrypted string.
             */
            return convertMatrixToString(TransposedMatrix);
        }

        /**
         * 
         * Encrypts ths string based on Transposition Cipher.
         * 
         * encryptedString - encrypted string of full name of the user - input parameter.
         * 
         * Returns the decrypted string - fullName.
         */
        public static string decryptString(string encryptedString)
        {
            /**
             * Calls convertStringToMatrix to create the encryptedStringMatrix.
             */
            char[,] encryptedStringMatrix = convertStringToMatrix(encryptedString);

            /**
             * Writes the text to the console.
             */
            Console.WriteLine("Encrypted string in Matrix form: ");

            /**
             * Calls the printMatrix methods and prints the matrix.
             */
            printMatrix(encryptedStringMatrix);

            /**
             * Calls transposeMatrix method and gets the TransposedMatrix.
             */
            char[,] transposedMatrix = ReverseTransposeMatrix(encryptedStringMatrix);

            /**
             * Writes the text to the console.
             */
            Console.WriteLine("\nShifted Matrix:");

            /**
             * Calls the printMatrix methods and prints the matrix.
             */
            printMatrix(transposedMatrix);

            /**
             * Calls convertMatrixToString method and returns the encrypted string.
             */
            return convertMatrixToString(transposedMatrix).Trim();
        }
    }
}
