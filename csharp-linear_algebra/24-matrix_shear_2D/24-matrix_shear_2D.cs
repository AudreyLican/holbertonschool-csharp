using System;
/// <summary>
/// class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="direction"></param>
    /// <param name="factor"></param>
    /// <returns></returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check if the matrix is square
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] { { -1 } };

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        // Apply the shear transformation based on the direction
        if (direction == 'x' || direction == 'X')
        {
            // Horizontal shear (shear in the X direction)
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    result[i, j] = matrix[i, j] + factor * i; // Apply the shear transformation in the X direction
        }
        else if (direction == 'y' || direction == 'Y')
        {
            // Vertical shear (shear in the Y direction)
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    result[i, j] = matrix[i, j] + factor * j; // Apply the shear transformation in the Y direction
        }
        else
        {
            // Invalid direction, return matrix with -1
            return new double[,] { { -1 } };
        }

        return result;
    }
}
