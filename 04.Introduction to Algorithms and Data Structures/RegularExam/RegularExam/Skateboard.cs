using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{
    public class Skateboard
    {
        private string model;
        private double price;

        public Skateboard(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public string Model
        {
            get
            {
               return this.model;
            }
            set
            {
                //if (!(Regex.IsMatch(value, @"^[a-zA-Z]+$")))
                //{
                //    throw new ArgumentException("Wrong name!");
                //}
                this.model = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"Skateboard {this.Model} costs {this.Price:f2} lv.";
        }

    }
}