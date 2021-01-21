using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Zookeeper
    {
        public static List<Animal> animals = new List<Animal>();
        public static List<String> menu = new List<String>();
        public Zookeeper() 
        {
            CreateAnimals();
            DisplayMenu();
        }

        public static void CreateAnimals() 
        {
            animals.Add(new Butterfly());
            animals.Add(new ET());
            animals.Add(new Jackalope());
            animals.Add(new LuckDragon());
            animals.Add(new Unicorn());
            animals.Add(new Mogwai());
            
            foreach (var item in animals) 
            {
                menu.Add(item.Species);
            }
            menu.Add("Exit");

        }

        public static void DisplayMenu() 
        {
            int menuLength = menu.Count - 1;
            int i = 1;
            
            DisplayHeader("WELCOME TO THE MYTHICAL ZOO");
            
            foreach (var item in menu)
            {
                Console.WriteLine($"[{i}]:  {item}");
                i++;
            }

            Console.ReadKey();
        }

        public static void DisplayHeader(string headerName)
        {
            Console.Clear();
            Console.WriteLine(headerName.ToUpper());
            Console.WriteLine("===================================================");
        }

    }
}
