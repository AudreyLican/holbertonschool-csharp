using System;

namespace MyMath
{
    /// <summary>
    /// method that devide all elements of a matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// function that divide
        /// </summary>
        /// <param name="matrix">array of integers.</param>
        /// <param name="num">number to divide</param>
        /// <returns>new matrix containing</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            try
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] newMatrix = new int[rows, cols];

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        newMatrix[r, c] = matrix[r, c] / num;
                    }
                }
                return (newMatrix);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
