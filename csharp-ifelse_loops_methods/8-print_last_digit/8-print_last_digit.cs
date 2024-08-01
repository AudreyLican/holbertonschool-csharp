using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int isLastdigit = number % 10;
        if (isLastdigit < 0)
            isLastdigit *= -1;
        Console.Write(isLastdigit);

        return isLastdigit;
    }
}
