using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    internal class FlowerStore
    {
        private string name;
        private List<Flower> flowers;
        public FlowerStore(string name)
        {
            this.Name = name;
            this.flowers = new List<Flower>();
        }

        public string Name
        {
            get { return this.name;}
            private set
            {
                if (value.Length < 6 || value == null) throw new ArgumentException("Invalid flower store name!");
                this.name = value;
            }
        }

        public void AddFlower(Flower flower)
            => this.flowers.Add(flower);

        public bool SellFlower(Flower searchedFlower)
        {
            if (searchedFlower == null) return false;
            int index = this.flowers.FindIndex(f => f.Type == searchedFlower.Type &&
                                                    f.Price == searchedFlower.Price && f.Color == searchedFlower.Color);
            if(index == -1) return false;
            this.flowers.RemoveAt(index);
            return true;
        }
        
        public double CalculateTotalPrice()
            => this.flowers.Sum(f => f.Price);

        public Flower GetFlowerWithHighestPrice()
        {
            double price = this.flowers.Max(f => f.Price);
            return this.flowers.FirstOrDefault(f => f.Price == price);
        }

        public Flower GetFlowerWithLowestPrice()
        {
            double price = this.flowers.Min(f => f.Price);
            return this.flowers.FirstOrDefault(f => f.Price == price);
        }

        public void RenameFlowerStore(string newName)
            => this.Name = newName;

        public void SellAllFlowers()
            => this.flowers.Clear();

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            if (this.flowers.Count <= 0)
            {
                return $"Flower store {this.Name} has no available flowers.";
            }

            report
                .AppendLine($"Flower store {this.Name} has {this.flowers.Count} flower/s:");
            foreach (var flower in this.flowers)
            {
                report
                    .AppendLine(flower.ToString());
            }

            return report.ToString().Trim();
        }
    }
}
