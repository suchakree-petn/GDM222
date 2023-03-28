using System;

class Program
{
    static void Main(string[] args)
    {
        Vector2 center1 = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        Vector2 center2 = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        double radius1 = double.Parse(Console.ReadLine());
        double radius2 = double.Parse(Console.ReadLine());
        double lenght = Math.Sqrt((center2 - center1) * (center2 - center1));
        if (radius1 + radius2 >= lenght)
        {
            double A = (Math.Pow(radius1, 2) - Math.Pow(radius2, 2) + Math.Pow(lenght, 2)) / (lenght * 2);
            double h = Math.Sqrt(Math.Pow(radius1, 2) - Math.Pow(A, 2));
            Vector2 point1 = new Vector2(center1.x + A * (center2.x - center1.x) / lenght,
                                        center1.y + A * (center2.y - center1.y) / lenght);
            if (radius1 + radius2 == lenght)
            {
                Console.WriteLine(point1.x);
                Console.WriteLine(point1.y);
            }
            else
            {
                Vector2 point2 = new Vector2(point1.x + h * ((center2.y - center1.y) / lenght),
                                        point1.y - h * (center2.x - center1.x) / lenght);
                Vector2 point3 = new Vector2(point1.x - h * ((center2.y - center1.y) / lenght),
                                            point1.y + h * (center2.x - center1.x) / lenght);
                Console.WriteLine(point3.x);
                Console.WriteLine(point3.y);
                Console.WriteLine(point2.x);
                Console.WriteLine(point2.y);
            }
        }
        else
        {
            Console.WriteLine(" ");
        }
    }
}