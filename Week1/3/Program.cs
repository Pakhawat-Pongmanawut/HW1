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
        if ((n > -1) && (n < 0))
        {
            return (Math.Sqrt(1 - (Math.Pow(n,2))));;
        }
        else if ((n > 0) && (n < 1))
        {
            return -(Math.Sqrt(1 - (Math.Pow(n,2))));
        }
        else if (n <= -1)
        {
            return PFunc(n + 2);
        }
        else
        {
            return PFunc(n - 2);
        }
    }
    }
