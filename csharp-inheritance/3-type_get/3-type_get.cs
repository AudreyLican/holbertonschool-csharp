using System;
using System.Collections.Generic;
using System.Reflection;
using System.Globalization;
using System.Text;

class Obj
{
    /// <summary>
    /// Method that print the name of the  available properties and methods of an object. 
    /// See example for output format.
    /// </summary>
    public static void Print(object myObj)
    {
        // Get type info of the object
        Type tinfo = myObj.GetType();
        TypeInfo my_type = tinfo.GetTypeInfo();

        Console.WriteLine("{0} Properties:", my_type.Name);
        foreach (PropertyInfo p in my_type.GetProperties())
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine("{0} Methods:", my_type.Name);
        foreach (MethodInfo m in my_type.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}