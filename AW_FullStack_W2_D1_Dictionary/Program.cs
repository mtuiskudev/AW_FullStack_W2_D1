﻿using System;
using System.Collections.Generic;

namespace AW_FullStack_W2_D1_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> simpleDictionary = new Dictionary<int, string>();
            simpleDictionary.Add(1, "eka");
            simpleDictionary.Add(2, "den andra");
            simpleDictionary.Add(3, "the third");

            Console.WriteLine(simpleDictionary.Values);

            //simpleDictionary.Add(3, "the third");
            //simpleDictionary[2] = "toinen";



            if(simpleDictionary.ContainsKey(4))
            {
                Console.WriteLine("Nelonen löytyi!\n");
            }
            else
            {
                Console.WriteLine("Ei nelosta :(\n");
            }


            //Dictionary<int, Car> cDictionary = new Dictionary<int, Car>();
            //Car fiat = new Car("Fiat", "Punto", 2004);

            //cDictionary.Add(1, fiat);


        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
    }
}
