using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int numMax = myList[0];
        foreach (int i in myList)
        {
            if (i > numMax)
                numMax = i;
        }
        return numMax;
    }
}