class Program
{

    static void Main(string[] args)
    {
        Console.Write("Max Node: ");
        int maxNodeCount = int.Parse(Console.ReadLine());
        Graph graph = new Graph(maxNodeCount);
        while (true)
        {
            Console.Write("Source: ");
            int sourceNode = int.Parse(Console.ReadLine());
            if (sourceNode + 1 > maxNodeCount || sourceNode < 0)
            {
                break;
            }
            Console.Write("Destination: ");
            int destNode = int.Parse(Console.ReadLine());
            if (destNode + 1 > maxNodeCount || destNode < 0)
            {
                break;
            }
            graph.AddEdge(sourceNode, destNode);
        }
        if (graph.IsReachable(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())))
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
    }
}