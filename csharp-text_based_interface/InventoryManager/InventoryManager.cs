using System;
using System.Collections.Generic;

namespace IventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage storage = new JSONStorage();
            storage.Load();
        }
    }
}
