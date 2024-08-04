using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> isDivBy2 = new List<bool>();

        foreach (int i in myList)
        {
            if (i % 2 == 0)
                isDivBy2.Add(true);
            else
                isDivBy2.Add(false);
        }
        return isDivBy2;
    }
}