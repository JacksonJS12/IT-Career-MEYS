using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExam
{
    public class Perfume
    {
        public Perfume(string brand,  double price)
        {
            if (price > 100) throw new ArgumentException("Invalid perfume price!");
            this.Brand = brand;
            this.Price = price;
        }
        public string Brand { get; }
        public double Price { get; }

        public override string ToString()
            => $" Perfume {this.Brand} costs {this.Price:f2}";
    }
}
