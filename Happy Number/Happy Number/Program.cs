int n, r = 1, num, sum = 0;

Console.Write("Enter Number : ");
n = Convert.ToInt32(Console.ReadLine());

num = n;
while (num > 9)
{
    while (num > 0)
    {
        r = num % 10;
        sum = sum + (r * r);
        num = num / 10;
    }
    num = sum;
    sum = 0;
}
if (num == 1)
{
    Console.WriteLine("Happy Number");
}
else
{
    Console.WriteLine("Not Happy Number");
}
  