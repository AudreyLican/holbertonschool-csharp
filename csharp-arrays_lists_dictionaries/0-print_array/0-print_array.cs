using System;

class Array
{
    public static int[] CreatePrint(int size)
    {

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] numArray = new int[size];

        if (size == 0)
        {
            Console.Write("\n");
            return numArray;
        }

        for (int i = 0; i < size; i++)
        {
            Console.Write("{0}{1}", i, i != size - 1 ? " " : "");
            numArray[i] = i; 
        }
        Console.Write("\n");
        return numArray;
    }
}
