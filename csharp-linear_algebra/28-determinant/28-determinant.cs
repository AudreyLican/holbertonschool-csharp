using System;
/// <summary>
/// class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    ///  method that calculates the determinant of a matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static double Determinant(double[,] matrix)
    {
        // Check if the matrix is 2x2 or 3x3
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols || (rows != 2 && rows != 3))
            return -1; // If the matrix is not 2x2 or 3x3, return -1

            // If it's a 2x2 matrix, use the 2x2 determinant formula
        if (rows == 2)
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        // If it's a 3x3 matrix, use the 3x3 determinant formula (Cofactor Expansion)
        if (rows == 3)
        {
            double a = matrix[0, 0], b = matrix[0, 1], c = matrix[0, 2];
            double d = matrix[1, 0], e = matrix[1, 1], f = matrix[1, 2];
            double g = matrix[2, 0], h = matrix[2, 1], i = matrix[2, 2];

            return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
        }

        return -1; // Fallback in case of invalid input (shouldn't be reached due to earlier check)
    }
}
