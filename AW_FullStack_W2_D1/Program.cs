using System;
using System.Collections.Generic;

namespace AW_FullStack_W2_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cList = new List<Car>();

            Car ford = new Car("Ford", "GT40", 1960);
            cList.Add(ford);

            Car nissan = new Car("Nissan", "GT-R", 2012);
            cList.Add(nissan);

            Car ferrari = new Car("Ferrari", "GTO", 1992);
            cList.Add(ferrari);

            Console.WriteLine(cList[1].Make);


            foreach (Car c in cList)
            {
                Console.WriteLine(c.Make + " " + c.Model + " " + c.Year);
            }

            Console.WriteLine(Environment.NewLine);

            cList.Sort((x, y) => x.Year.CompareTo(y.Year));

            foreach(Car c in cList)
            {
                Console.WriteLine(c.Make + " " + c.Model + " " + c.Year);
            }


            Console.WriteLine(Environment.NewLine);

            /*Car haettu = cList.Find(c => c.Make == "Nissan");

            haettu.Model = "Silvia";

            foreach (Car c in cList)
            {
                Console.WriteLine(c.Make + " " + c.Model + " " + c.Year);
            }*/
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
