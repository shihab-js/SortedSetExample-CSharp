using System;
using System.Collections.Generic;

namespace SortedSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create sorted set 
            var names = new SortedSet<string>();

            names.Add("Shihab");
            names.Add("Mishu");
            names.Add("Rayhan");


            //iterate the sorted set
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            //create a SortedSet using collection initiazer
            var cities = new SortedSet<string>()
            {
                "Dhaka",
                "San-Francisco",
                "Hongkong"

            };

            Console.WriteLine("Iterate the cities sorted set");
            //iterate the cities SortedSet
            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
