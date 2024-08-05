using System;
using System.Collections.Generic;

/**
    Write a method that adds all unique integers in a list.
    return the sum of unique integers in given list.
*/
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