using System;
using System.Collections.Generic;

/*
    Write a method that creates and prints a LinkedList of integers of a given size.
*/
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLList = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            newLList.AddLast(i);
            Console.WriteLine(i);
        }

        return newLList;
    }
}
