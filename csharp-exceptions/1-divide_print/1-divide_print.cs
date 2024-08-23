using System;
using System.Collections.Generic;

class Int
{
    public static void divide(int a, int b)
    {
        int sum = 0;
        try
        {
            sum = a / b;
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, sum);
        }
    }
}