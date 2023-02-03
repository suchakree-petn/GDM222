class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double ans = condition(n);
        if (ans == -999)
        {
            Console.WriteLine("Error");

        }
        else
        {
            Console.WriteLine(ans);

        }

    }
    static double condition(double n)
    {
        if (n > 1)
        {
            return condition(n - 2);
        }
        else if (n <= -1)
        {
            return condition(n + 2);
        }
        else if (n > -1 && n <= 0)
        {
            return Math.Sqrt(1 - (n * n));
        }
        else if (n > 0 && n <= 1)
        {
            return -1*Math.Sqrt(1 - (n * n));
        }
        return -999;
    }
}