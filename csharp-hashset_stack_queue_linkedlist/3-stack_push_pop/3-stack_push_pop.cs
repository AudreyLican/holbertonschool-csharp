using System;
using System.Collections.Generic;

/*
    Print the number of items in aStack : Format: Number of items: <number>
*/
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of item in aStack
        Console.WriteLine("Number of items: {0}", aStack.Count);

        //Print the item at the top of astack w/o removing it
        if (aStack == null)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}",  aStack.Peek());

        // if if aStack contains seach, remove all items up to and including search
        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains {0}: True", search);
            while(aStack.Contains(search))
                aStack.Pop();
        }
        else
            Console.WriteLine("Stack contains {0}: False", search);

        // Add new given item : newItem to aStack
        aStack.Push(newItem);

        return aStack;
    }
}