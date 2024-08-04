using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a 5 by 5 array
        int[,] numArray = new int[5, 5];

        // initialize all to 0
        for (int i= 0; i < 5; i++)
        {
            for (int j=0; j < 5; j++)
                numArray[i, j] = 0;
        }

        // set index to [2, 2] to 1
        numArray[2, 2] = 1;

        // print array
        for (int i= 0; i < 5; i++)
        {
            for (int j=0; j < 5; j++)
                Console.Write(numArray[i, j] + " ");
            Console.WriteLine();
        }
    }
}
