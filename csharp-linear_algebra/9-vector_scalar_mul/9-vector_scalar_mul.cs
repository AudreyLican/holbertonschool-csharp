using System;
/// <summary>
/// class Vector Math
/// </summary>
class VectorMath
{
    /// <summary>
    /// method that multiplies a vector and a scalar
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>return the resulting vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        // check if vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
            return new double[] {-1};

        double result = new double[vector.Length];

        // multiply each element of the vector by the scalar
        for (int i = 0; i < vector.Length; i++)
            result[i] = vector[i] * scalar;

        return result;
    }
}
