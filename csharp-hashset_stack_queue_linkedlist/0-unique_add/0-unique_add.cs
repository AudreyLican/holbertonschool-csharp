using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        // create hashset
        HashSet<int> uqInt = new HashSet<int>(myList);

        int sum = 0;

        foreach (int nbr in uqInt)
            sum += nbr;

        return sum;
    }
}