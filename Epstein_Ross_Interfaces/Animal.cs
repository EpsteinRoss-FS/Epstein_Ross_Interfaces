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

        private string _species;
        public string Species { 
            get { return _species; } 
        }
        
        public int _foodConsumed;


        public Animal(string species, int foodConsumed, string treat) 
        {
            _foodConsumed = foodConsumed;
            _treat = treat;
            _species = species;
            
        }


        public virtual string MakeNoise(string animalNoise, string animalName)
        {
            string noise = $"The {animalName} goes {animalNoise}"; 
            return noise;
        }

        //this may be my favorite method I've ever written - RE
        public static string Poop(string animalName) 
        {
            string poop = $"{animalName} has pooped!";
            return poop;
        }

        public string Eat(Animal animal, string animalName) 
        {
            animal._foodConsumed++;
            
            if (animal._foodConsumed >= 4)
            {
                
                animal._foodConsumed = 0;
                string poop = Poop(animalName);
                return($"{animalName} ate their 4th {animal.Treat}! {poop}");
            }
            else 
            { 
                return ($"{animalName} ate a {animal.Treat}");
            }

        }
        




    }

 
}
