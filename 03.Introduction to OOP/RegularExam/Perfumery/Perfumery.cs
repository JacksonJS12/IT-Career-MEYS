using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    public class Perfumery
    {
        private string name;
        private List<Perfume> perfumes;

        public Perfumery(string name)
        {
             this.Name = name;
             this.perfumes = new List<Perfume>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 6 || value == null) throw new ArgumentException("Invalid perfumery name!");
                this.name = value;
            }
        }

        public void AddPerfume(Perfume perfume)
            => this.perfumes.Add(perfume);

        public bool SellPerfume(Perfume perfume)
        {
            if (perfume == null) return false;
            int index = this.perfumes.FindIndex(p => p.Brand == perfume.Brand &&
                                                    p.Price == perfume.Price && p.Price == perfume.Price);
            if (index == -1) return false;
            this.perfumes.RemoveAt(index);
            return true;
        }
        public double CalculateTotalPrice()
            => this.perfumes.Sum(p => p.Price);

        public Perfume GetPerfumeWithHighestPrice()
        {
            double price = this.perfumes.Max(p => p.Price);
            return this.perfumes.FirstOrDefault(p => p.Price == price);
        }

        public Perfume GetPerfumeWithLowestPrice()
        {
            double price = this.perfumes.Min(p => p.Price);
            return this.perfumes.FirstOrDefault(p => p.Price == price);
        }

        public void RenamePerfumery(string newName)
            => this.Name = newName;

        public void SellAllPerfumes()
            => this.perfumes.Clear();

        public override string ToString()
        {
            if (this.perfumes.Count <= 0) return $" Perfumery {this.Name} has no available perfumes.".ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Perfumery {this.Name} has {this.perfumes.Count} perfume/s:");
            foreach (var perfume in this.perfumes)
            {
                sb.AppendLine(perfume.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
