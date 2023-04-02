namespace P01.Resurrection;
public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int lengthBody = int.Parse(Console.ReadLine());
            double widthBody = double.Parse(Console.ReadLine());
            int lengthEachWing = int.Parse(Console.ReadLine());

            double totalYears = Math.Pow(lengthBody, 2) * (widthBody + 2 * lengthEachWing);
            Console.WriteLine(totalYears);
        }
    }
}
