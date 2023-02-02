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
        if (n * n <= 4)
        {
            return 2;
        }
        else if (n * n > 4)
        {
            return 1 + condition(n - (4 * Math.Abs(n) / n));
        }
        return -999;
    }
}