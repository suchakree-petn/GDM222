class Program
{
    static void Main(string[] args)
    {
        List<Vector2> points = new List<Vector2>();
        while (true)
        {
            Vector2 inputPoint = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            if (inputPoint.x == 0 && inputPoint.y == 0)
            {
                break;
            }
            points.Add(inputPoint);
        }
        List<Line2> Lines = new List<Line2>();
        for (int i = 0; i < points.Count; i++)
        {
            Vector2 p1 = points[i];
            Vector2 p2 = points[(i + 1) % points.Count];
            Lines.Add(new Line2(p1, p2));
        }
        Vector2 testPoint = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        bool Is_inside = false;
        foreach (Line2 line in Lines)
        {
            Line2 perpendicular = Line2.Perpendicular(line, testPoint);
            Vector2 intersection = Line2.Intersection(line, perpendicular);
            if (intersection.x < Math.Min(line.p1.x, line.p2.x) ||
                intersection.x > Math.Max(line.p1.x, line.p2.x) ||
                intersection.y < Math.Min(line.p1.y, line.p2.y) ||
                intersection.y > Math.Max(line.p1.y, line.p2.y))
            {
                Is_inside = true;
                break;
            }
        }
        if (Is_inside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}