using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> currentNode = myLList.First;

        while (currentNode != null)
        {
            if (currentNode.Value < n)
                currentNode = currentNode.Next;
            else
            {
                myLList.AddBefore(currentNode, n);
                return myLList.First;
            }
        }
        myLList.AddLast(n);
        return myLList.First;
    }
}
