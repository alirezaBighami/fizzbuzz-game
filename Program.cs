using static System.Console;
using System;

int max = 100;
for (int i = 1; i <= max; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Write("fizz");
    } else if (i % 3 != 0 && i % 5 == 0)
    {
        Write("buzz");
    } else if (i % 3 == 0 && i % 5 == 0)
    {
        Write("fizzbuzz");
    } else
    {
        Write(i.ToString());
    }
    if (i < max)
    {
        Write(", ");
    } else
    {
        Write(".");
    }
}