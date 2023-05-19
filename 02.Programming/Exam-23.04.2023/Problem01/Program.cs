namespace Problem01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem01
            //int n = int.Parse(Console.ReadLine());
            //var totalSum = 0;
            //int counter = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    var item = Console.ReadLine();
            //    if (item == "scalpel")
            //    {
            //        totalSum += 1500;
            //    }
            //    else if (item == "microscope")
            //    {
            //        totalSum += 6000;
            //    }
            //    else if (item == "syringe")
            //    {
            //        totalSum += 100;
            //    }
            //}
            //Console.WriteLine($"{totalSum:f2}");

            //Problem02
            //var list = Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //    .ToList();

            //while (true)
            //{
            //    var cmd = Console.ReadLine();

            //    if (cmd == "END OF OWNERS")
            //    {
            //        break;
            //    }

            //    if (cmd == "Add owner")
            //    {
            //        var person = Console.ReadLine();
            //        list.Add(person);
            //    }
            //    else if (cmd == "Add owner on position")
            //    {
            //        var person = Console.ReadLine();
            //        var position = int.Parse(Console.ReadLine());

            //        list.Insert(position, person);

            //    }
            //    else if (cmd == "Remove owner on position")
            //    {
            //        var position = int.Parse(Console.ReadLine());
            //        list.RemoveAt(position);
            //    }
            //    else if (cmd == "Remove last owner")
            //    {
            //        list.RemoveAt(list.Count-1);
            //    }
            //    else if (cmd == "Remove first owner")
            //    {
            //        list.RemoveAt(0);
            //    }
            //}

            //Console.WriteLine(string.Join(" ", list));

            //Problem04
            //string input = Console.ReadLine();
            //string chars = string.Empty;
            //foreach (char ch in input)
            //{
            //    if (chars.Contains(ch) || ch == ' ')
            //    {
            //       continue;
            //    }
            //    int chCount = input.Count(t => t == ch);
            //    chars += ch;
            //    Console.WriteLine($"{ch} -> {chCount}");
            //}

            //Problem03
            string input = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            foreach (char ch in input)
            {
                if (ch == ' ')
                {
                    continue;
                }

                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                else
                {
                    others += ch;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}