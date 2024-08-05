using System;
using System.Collections.Generic;

/*
    Write a method that returns the sum of all the data of a LinkedList.
    Returns the sum of the data in the LinkedList.
*/
class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;

        foreach(int i in myLList)
        {
            sum += i;
        }

        return sum;
    }
}
