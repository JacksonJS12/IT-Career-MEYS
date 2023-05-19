using System.Security.AccessControl;

namespace P02.AnimalFarm
{
    public class Chicken
    {
        private string _name;
        private int _age;
        private double _eggs;

        public Chicken(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string Name
        {
            get { return this._name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this._name = value;
            }
        }
        public int Age
        {
            get { return this._age; }
             set
            {
                if (value > 0 && value <= 15)
                {
                    throw new InvalidOperationException("Age should be between 0 and 15.");
                }

                this._age = value;
            }
        }

        private double CalculateProductPerDay()
        {
            return this.Age / 10;
        }

        public void productPerDay()
        {
            this._eggs = CalculateProductPerDay();
        }

        public override string ToString()
        {
            return $"Chicken {this.Name} (age {this.Age}) can produce {this._eggs} eggs per day.";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                while (true)
                {
                    string name = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());
                    Chicken chicken = new Chicken(name, age);
                    chicken.productPerDay();
                    Console.WriteLine(chicken.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }
    }
}