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
            numArray[i] = i; 
            Console.Write(i + " ");
        }
        Console.Write("\n");
        return numArray;
    }
}
