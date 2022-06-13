using System;
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



            Console.WriteLine(Environment.NewLine);
            
            Dictionary<int, Car> cDictionary = new Dictionary<int, Car>();
            Car fiat = new Car("Fiat", "Punto", 2004);

            Console.WriteLine(fiat.Year);

            cDictionary.Add(1, fiat);

            Car haettu = null;
            cDictionary.TryGetValue(1, out haettu);

            haettu.Year = 1994;

            Console.WriteLine(cDictionary[1].Year);
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
