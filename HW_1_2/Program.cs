
class Program
{
    static void Main(string[] args)
    {
        double[] C = { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };
        double[] P = { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };
        int repeat = int.Parse(Console.ReadLine());
        double[] lastCircle = circle(C, P, ref repeat);
        foreach (double LC in lastCircle)
        {
            Console.WriteLine(LC);
        }
    }
    static double[] circle(double[] C, double[] P, ref int repeat)
    {
        double[] originC = { C[0] - C[0], C[1] - C[1] };
        double[] originP = { P[0] - C[0], P[1] - C[1] };
        double r = Math.Sqrt(Math.Pow(originP[0], 2) + Math.Pow(originP[1], 2));
        double theta = Math.Atan2(originP[1], originP[0]) * 180 / Math.PI;
        theta += 90;
        theta *= Math.PI / 180;
        double[] newP = { Math.Round(Math.Cos(theta) * r * 1000) / 1000, Math.Round(Math.Sin(theta) * r * 1000) / 1000 };
        double[] newC = { (originC[0] + newP[0]) / 2, (originC[1] + newP[1]) / 2 };
        double[] ans = { newC[0] + C[0], newC[1] + C[1], newP[0] + C[0], newP[1] + C[1] };
        double[] ansC = { ans[0], ans[1] };
        double[] ansP = { ans[2], ans[3] };
        repeat--;
        if (repeat <= 0)
        {
            return ans;
        }
        else
        {
            ans = circle(ansC, ansP, ref repeat);
        }
        return ans;
    }
}