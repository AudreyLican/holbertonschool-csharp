using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        //verify if vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
            return -1;

        //calculate the sum of carré of components
        double sumNum = 0;
        foreach (double component in vector)
        {
            sumNum += Math.Pow(component, 2);
        }

        // caculate racine carrée
        double magnitude = Math.Sqrt(sumNum);

        //round at 2 decimal and return
        return Math.Round(magnitude, 2);
    }
}
