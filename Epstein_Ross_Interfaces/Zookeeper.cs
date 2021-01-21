using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Zookeeper
    {
        public static List<Animal> animals = new List<Animal>();
        public static List<String> menu = new List<String>();
        public static Animal selectedAnimalObj;

        public static List<string> animalOptions = { }

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

            Console.Write("Please make a selection >  ");
            string _userChoice = Console.ReadLine();

            //validate the choice is an integer
            bool isInt = Validation.CheckInt(_userChoice);
            int _userChoiceInt = isInt ? Int32.Parse(_userChoice) : 000;

            //validate the choice is in range of the menu
            bool isInRange = Validation.CheckRange(_userChoiceInt, menuLength + 1);

            //ask again if the validation returns false
            while (!isInt || !isInRange)
            {
                i = 1;
                DisplayHeader("WELCOME TO THE MYTHICAL ZOO");

                foreach (var item in menu)
                {
                    Console.WriteLine($"[{i}]:  {item}");
                    i++;
                }

                //error if menu selection out of range    
                Console.Write($"Invalid entry!  Please enter a number between 1 and {menuLength} > ");
                _userChoice = Console.ReadLine();
                isInt = Validation.CheckInt(_userChoice);
                _userChoiceInt = isInt ? Int32.Parse(_userChoice) : 000; ;
                isInRange = Validation.CheckRange(_userChoiceInt, (menuLength + 1));
            }

            string chosenItem = menu[_userChoiceInt - 1];
            //Console.WriteLine(chosenItem);
            Console.WriteLine("They chose " + chosenItem);
            Animal _selectedAnimal = GetSelectedAnimal(chosenItem);
            Console.WriteLine("Did it work? " + _selectedAnimal.Species);
            Console.ReadKey();
            AnimalOptionsMenu(_selectedAnimal);
            
        }

        public static void DisplayHeader(string headerName)
        {
            Console.Clear();
            Console.WriteLine(headerName.ToUpper());
            Console.WriteLine("===================================================");
        }

        public static Animal GetSelectedAnimal(string chosenAnimalName) 
        {

            //Animal selectedAnimalObj = animals.Where(animals => animals.Species == chosenAnimalName);
            selectedAnimalObj = animals.Find(x => x.Species == chosenAnimalName);

            Console.WriteLine("it pulled " + selectedAnimalObj.Species);
            Console.ReadKey();
            
            
            return (Animal)selectedAnimalObj;
        }

        public static void AnimalOptionsMenu(Animal animal) 
        {

            if (animal is ITrainable)
            {
                
            }
        }

    }
}
