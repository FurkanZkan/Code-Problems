
using System;

int fibonacciSeries(int length)
{
    if (length == 0 || length == 1)
        return 1;


    return fibonacciSeries(length - 1) + fibonacciSeries(length -2);
}


Console.Write("Length of the Fibonacci Series: ");
int length = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < length; i++)
{
    Console.Write("{0} ", fibonacciSeries(i));
}



