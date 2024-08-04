using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int i;

        if (array == null)
            Console.WriteLine("");

        else
        {
            for (i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}{1}", array[i], i > 0 ? " " : "");
            }
        }
        Console.Write("\n");
    }
}
