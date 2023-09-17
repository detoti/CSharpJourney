class Program
{
    static void Main(string[] args)
    {
        int linesToRead = int.Parse(Console.ReadLine());
        int totalDistance = 0;

        for (int i = 0; i < linesToRead; i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            if (values.Length == 2)
            {
                
                int time = int.Parse(values[0]);
                int speed = int.Parse(values[1]);

                int distance = time * speed;
                totalDistance += distance;
            }
            else
            {
                return;
            }
        }
        Console.WriteLine(totalDistance);
    }
}