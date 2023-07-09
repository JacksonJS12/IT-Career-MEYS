﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{
    public class SkateboardShop
    {
        private string name;
        private List<Skateboard> skateboards;

        public SkateboardShop(string name)
        {
            this.skateboards = new List<Skateboard>();
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                //if (!(Regex.IsMatch(value, @"^[a-zA-Z]+$")))
                //{
                //    throw new ArgumentException("Wrong name!");
                //}
                this.name = value;
            }
        }
        public List<Skateboard> Skateboards
        {
            get
            {
                return this.skateboards;
            }
            set
            {
                this.skateboards = value;
            }
        }

        public void AddSkateboard(string model, double price)
        {
            Skateboard skateboard = new Skateboard(model, price);
            this.skateboards.Add(skateboard);
        }

        public double AveragePriceInRange(double start, double end)
        {
            int count = 0;
            double sum = 0;
            foreach (var skateboard in this.skateboards)
            {
                if (skateboard.Price <= end && skateboard.Price >= start)
                {
                    count++;
                    sum += skateboard.Price;
                }
            }
            return sum / count;
        }

        public List<string> FilterSkateboardsByPrice(double price)
        {
            List<string> list = new List<string>();
            foreach (var skateboard in this.skateboards)
            {
                if (skateboard.Price < price)
                {
                    list.Add(skateboard.Model);
                }
            }
            return list;
        }

        public List<Skateboard> SortAscendingByModel()
        {
            return this.skateboards.OrderBy(s => s.Model).ToList();
        }

        public List<Skateboard> SortDescendingByPrice()
        {
            return this.skateboards.OrderByDescending(s => s.Price).ToList();
        }

        public bool CheckSkateboardIsInShop(string model)
        {
            return this.skateboards.Any(s => s.Model == model);
        }

        public string[] ProvideInformationAboutAllSkateboards()
           => this.skateboards.Select(x => x.ToString()).ToArray();
    }
}
