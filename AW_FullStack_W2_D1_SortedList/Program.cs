using System;
using System.Collections.Generic;

namespace AW_FullStack_W2_D1_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> yksinkertainen = new SortedList<int, string>();

            yksinkertainen.Add(5, "Alfa Romeo");
            yksinkertainen.Add(1, "Red Bull");
            yksinkertainen.Add(2, "Ferrari");
            yksinkertainen.Add(7, "Alfa Tauri");

            yksinkertainen.Add(4, "McLaren");
            yksinkertainen.Add(9, "Haas");
            yksinkertainen.Add(6, "Alpine");
            
            yksinkertainen.Add(8, "Aston Martin");
            
            yksinkertainen.Add(10, "Williams");
            yksinkertainen.Add(3, "Mercedes AMG");

            foreach (KeyValuePair<int, string> pair in yksinkertainen)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            Console.WriteLine(yksinkertainen.Capacity);

            Console.WriteLine(yksinkertainen.Count);

        }
    }
}
