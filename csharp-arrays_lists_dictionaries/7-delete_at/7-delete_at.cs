using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        int toRemove = myList[index];
        myList.Remove(toRemove);
        return myList;
    }
}
