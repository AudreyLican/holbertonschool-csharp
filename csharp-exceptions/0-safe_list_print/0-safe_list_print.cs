using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i;

        try
        {
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
        catch
        {
        }
        /*
        for (i = 0; i < n; i++)
        {
            try
            {
                Console.WriteLine(myList[i]);
            }
            catch
            {
                break;
            }
        }*/
        return i;
    }
}
