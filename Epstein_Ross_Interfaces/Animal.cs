using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Animal
    {
        protected string _treat;
        public string Treat 
        {
            get{ return _treat; }
            set { _treat = value; }
        }
        
        public int _foodConsumed;


        public Animal(int foodConsumed = 0, string treat = "cabbage") 
        {
            _foodConsumed = foodConsumed;
            _treat = treat;
        }


        public virtual string MakeNoise(string noise)
        {
            return noise;
        }

        //this may be my favorite method I've ever written - RE
        public static void Poop(string animalName) 
        {
            Console.WriteLine($"{animalName} has pooped!");
            Console.ReadKey();
        }

        public static string Eat(Animal animal, string animalName) 
        {
            animal._foodConsumed++;
            
            if (animal._foodConsumed >= 4)
            {
                Console.WriteLine($"{animalName} ate their 4th {animal.Treat}!");
                animal._foodConsumed = 0;
                Poop(animalName);
            }
            return ($"{animalName} ate a {animal.Treat}");
        }
        




    }

 
}
