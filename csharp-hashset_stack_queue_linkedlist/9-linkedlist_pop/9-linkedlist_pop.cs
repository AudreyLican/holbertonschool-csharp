using System;
using System.Collections.Generic;

class LList
{
    // Main - entry point
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count <= 0)
            return 0;

        int f = myLList.First.Value; // get the value of the first node
        myLList.RemoveFirst();

        return f;
    }
}
