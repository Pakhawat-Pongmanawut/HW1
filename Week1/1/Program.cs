using System;
class Program
    {
     public static void Main()
     {
        double n;
        n = double.Parse(Console.ReadLine());
        Console.WriteLine(PFunc(n));
     }
    public static double PFunc(double n)
    {
        if ((Math.Pow(n,2)) <= 4)
        {
            return 2;
        }
        else
        {
            return (1 + PFunc(n - (4 * (Math.Abs(n)) / n)));
        }
    }
    }