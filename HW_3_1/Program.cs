class Program
{
    static void Main(string[] args)
    {
        Vector2 p1 = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        Vector2 p2 = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        Vector2 p3 = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        Line2 line1 = new Line2(p1, p2);
        Line2 line2 = new Line2(p2, p3);
        Line2 linePerp1 = Line2.Perpendicular(line1, new Vector2((p1.x + p2.x) / 2, (p1.y + p2.y) / 2));
        Line2 linePerp2 = Line2.Perpendicular(line2, new Vector2((p2.x + p3.x) / 2, (p2.y + p3.y) / 2));

        Vector2 center = Line2.Intersection(linePerp1, linePerp2);
        Console.WriteLine(center.x);
        Console.WriteLine(center.y);
        double radius = Math.Sqrt(Math.Pow((p1.x - center.x), 2) + Math.Pow((p1.y - center.y), 2));
        Console.WriteLine(radius);
    }
}