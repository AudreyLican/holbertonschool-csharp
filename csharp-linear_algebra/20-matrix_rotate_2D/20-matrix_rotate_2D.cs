using System;
/// <summary>
/// class matrix math
/// </summary>

class MatrixMath
{
    /// <summary>
    /// method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the matrix is square
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] { { -1 } }; // If not square, return a matrix containing -1

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        // Apply the rotation formula to each element
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
            {
                // Treat matrix[i, j] as (x, y) where x is the element itself and y is its index
                double y = i; // Row index as the y-coordinate

                // Apply rotation formula
                double newX = x * Math.Cos(angle) - y * Math.Sin(angle);
                double newY = x * Math.Sin(angle) + y * Math.Cos(angle);

                // Store the new value in the result matrix
                result[i, j] = newX; // We're rotating only the x-value of the element
            }

        return result;
    }
}