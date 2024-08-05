using System;
using System.Collections.Generic;
class LList
{
    // Main - entry point
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList.Count < n)
            return 0;

        int index = 0;
        foreach(int j in myLList)
        {
            if (index == n)
                return j;
            index++;
        }

        return 0;
    }
}