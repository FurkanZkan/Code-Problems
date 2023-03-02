double number;
start:
Console.Write("What number do you want to find the square root of :");
number = double.Parse(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("please enter a value greater than 0 ");
    goto start;
}
else
{
    Console.WriteLine("{0} square root of the number : {1}", number, NewtonSqrtSlgorithm(number));
}

double NewtonSqrtSlgorithm(double num)
{
    double x1 = 0;
    double x2 = num / 2;
    if (num != 0)
    {
        do
        {
            x1 = x2;
            x2 = (x1 + (num / x1)) / 2;
        } while (x2 - x1 != 0);
    }
    else
    {
        x2 = 0;
    }
    return x2;
}
