using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            int nbr1 = i % 10;
            int nbr2 = i / 10;

            if (nbr1 != nbr2 && nbr2 < nbr1)
                {
                    if (i != 89)
                        Console.Write("{0:D2}, ", i);
                    else
                        Console.WriteLine("{0:D2}", i);
                }
        }
    }
}
