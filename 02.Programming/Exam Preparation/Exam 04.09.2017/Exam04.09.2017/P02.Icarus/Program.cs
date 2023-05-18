using System.Reflection.PortableExecutable;

namespace P02.Icarus;
public class Program
{
    static void Main(string[] args)
    {
        var sequence = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        var position = int.Parse(Console.ReadLine());
        var cmd = Console.ReadLine().Split();
        var dmg = 1;
        while (true)
        {
            if (cmd[0] == "Supernova")
            {
                break;
            }

            string direction = cmd[0];
            var steps = int.Parse(cmd[1]);

            var lastPosition = position;
            if (direction == "left")
            {
                position -= steps; 
            }
            else if (direction == "right")
            {
                position += steps;
            }

            if (position < 0)
            {
                position = sequence.Count - 1;
                dmg++;
            }
            else if (position > sequence.Count)
            {
                position = 0;
                dmg++;
            }

            var end = 0;
            var start = 0;
            if (position > lastPosition)
            {
                end = position;
                start = lastPosition + 1;
            }
            else if(position < lastPosition)
            {
                end = lastPosition -1;
                start = position;
            }

            
            for (int i = start; i <= end; i++)
            {
                sequence[i] -= dmg;
            }
             
            cmd = Console.ReadLine().Split();
        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}
