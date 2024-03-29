﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace P18.SmallShop
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var townsStocksAndPrices = new Dictionary<string, Dictionary<string, double>>()
            {
                { "sofia", new Dictionary<string, double>()
                    {
                        {"coffee", 0.5} ,
                        {"water", 0.8 },
                        {"beer", 1.2 },
                        {"sweets", 1.45},
                        {"peanuts", 1.6 }
                    }
                },

                { "plovdiv", new Dictionary<string, double>()
                    {
                        {"coffee", 0.4} ,
                        {"water", 0.7 } ,
                        {"beer", 1.15 },
                        {"sweets", 1.3},
                        {"peanuts", 1.5 }
                    }
                },

                { "varna", new Dictionary<string, double>()
                    {
                        {"coffee", 0.45} ,
                        {"water", 0.7},
                        {"beer", 1.10 },
                        {"sweets", 1.35 },
                        {"peanuts", 1.55 }
                    }
                }
            };

            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine().ToLower());

            foreach (var currTown in townsStocksAndPrices.Keys)
            {
                if (town == currTown)
                {
                    foreach (var currProduct in townsStocksAndPrices[currTown])
                    {
                        if (product == currProduct.Key)
                        {
                            Console.WriteLine((decimal)(currProduct.Value * quantity));
                        }
                    }
                }
            }
        }
    }
}
