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

        public static List<string> nonTrainableMenu = new List<string> { "Listen to a Noise", "Feed Animal A Treat", "Select Different Animal" };
        public static List<string> trainableMenu = new List<string> { "Listen to a Noise", "Feed Animal A Treat", "Select Different Animal", "Train The Animal", "Signal A Behavior" };

        public static bool exited = false;
        public Zookeeper()
        {
            CreateAnimals();
            while (!exited) 
            { 
                DisplayMenu();
            }
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
            Animal _selectedAnimal = GetSelectedAnimal(chosenItem);
            if (chosenItem.ToLower() == "exit") 
            {
                exited = true;
                Console.WriteLine("Thank your for visiting the Mystical Zoo! Have a great day!");
                return;
            }
            
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

            return (Animal)selectedAnimalObj;
        }

        public static void AnimalOptionsMenu(Animal animal)
        {
            List<string> menuToUse = new List<string>();

            if (animal is ITrainable)
            {
                menuToUse = trainableMenu;
            }

            else
            {
                menuToUse = nonTrainableMenu;
            }

            int menuLength = menuToUse.Count - 1;
            int i = 1;
            Console.Clear();
            DisplayHeader($"Selected Animal: {animal.Species}");

            foreach (var item in menuToUse)
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
                Console.Clear();
                DisplayHeader($"Selected Animal: {animal.Species}");

                foreach (var item in menuToUse)
                {
                    Console.WriteLine($"[{i}]:  {item}");
                    i++;
                }

                Console.Write("Please make a selection >  ");

                //error if menu selection out of range    
                Console.Write($"Invalid entry!  Please enter a number between 1 and {menuLength} > ");
                _userChoice = Console.ReadLine();
                isInt = Validation.CheckInt(_userChoice);
                _userChoiceInt = isInt ? Int32.Parse(_userChoice) : 000; ;
                isInRange = Validation.CheckRange(_userChoiceInt, (menuLength + 1));
            }

            string chosenItem = menuToUse[_userChoiceInt - 1];

            switch (chosenItem.ToLower())
            {
                //"Listen to a Noise", "Feed Animal A Treat", "Select Different Animal", "Train The Animal", "Signal A Behavior"
                case "listen to a noise":
                    MakeNoiseCall(animal);
                    break;
                case "feed animal a treat":
                    FeedAnimal(animal);
                    break;
                case "select different animal":
                    return;
                case "train the animal":
                    TrainAnimal(animal);
                    break;
                case "signal a behavior":
                    SignalBehavior(animal);
                    break;

            }

        }


        public static void MakeNoiseCall(Animal animal)
        {
            if (animal is Unicorn) 
            {
                Console.WriteLine(((Unicorn)animal).MakeNoise(((Unicorn)animal).Noise));
                Console.WriteLine("Press Any Key To Continue...");
            }
            if (animal is Butterfly)
            {
                Console.WriteLine(((Butterfly)animal).MakeNoise(((Butterfly)animal).Noise));
                Console.WriteLine("Press Any Key To Continue...");
            }
            if (animal is Jackalope)
            {
                Console.WriteLine(((Jackalope)animal).MakeNoise(((Jackalope)animal).Noise));
                Console.WriteLine("Press Any Key To Continue...");
            }
            if (animal is LuckDragon)
            {
                Console.WriteLine(((LuckDragon)animal).MakeNoise(((LuckDragon)animal).Noise));
                Console.WriteLine("Press Any Key To Continue...");
            }
            if (animal is Mogwai)
            {
                Console.WriteLine(((Mogwai)animal).MakeNoise(((Mogwai)animal).Noise));
                Console.WriteLine("Press Any Key To Continue...");
            }
            if (animal is ET)
            {
                Console.WriteLine(((ET)animal).MakeNoise(((ET)animal).Noise));
                Console.WriteLine("Press Any Key To Continue...");
            }
            return;

        }

        public static void FeedAnimal(Animal animal) 
        {
            Console.WriteLine(animal.Eat(animal, animal.Species));
            Console.ReadKey();
        }

        public static void TrainAnimal(Animal animal) 
        {
            Console.Clear();
            DisplayHeader($"train {animal.Species}");

            Console.Write($"What would you like to train the {animal.Species} to do?  >  ");
            string desiredTask = Console.ReadLine();
            bool stringValid = Validation.ValidateString(desiredTask);

            while (!stringValid) 
            {
                Console.Clear();
                DisplayHeader($"train {animal.Species}");
                Console.WriteLine("Invalid Entry!");
                Console.Write($"What would you like to train the {animal.Species} to do?  >  ");
                desiredTask = Console.ReadLine();
                stringValid = Validation.ValidateString(desiredTask);

            }
            
            Console.Clear();
            DisplayHeader($"train {animal.Species}");
            Console.Write($"What would you like the trigger for this behavior to be?  >  ");
            string desiredTrigger = Console.ReadLine();

            bool triggerStringValid = Validation.ValidateString(desiredTrigger);

            while (!triggerStringValid)
            {
                Console.Clear();
                DisplayHeader($"train {animal.Species}");
                Console.WriteLine("Invalid Entry!");
                Console.Write($"What would you like the trigger for this behavior to be?  >  ");
                desiredTrigger = Console.ReadLine();
                triggerStringValid = Validation.ValidateString(desiredTrigger);
            }

            
            if (animal is LuckDragon)
            {
                //((LuckDragon)animal);
                
            }
            if (animal is Mogwai)
            {
                string trainedDescriptor = ((Mogwai)animal).Train(desiredTrigger, desiredTask);
                Console.WriteLine(trainedDescriptor);
                Console.WriteLine("Press Any Key To Continue...");
                Console.ReadKey();
            }
            if (animal is ET)
            {
                Console.WriteLine(((ET)animal).MakeNoise(((ET)animal).Noise));
                Console.WriteLine("Press Any Key To Continue...");
            }

          
        }

        public static void SignalBehavior(Animal animal)
        {
            foreach (var behavior in ((Mogwai)animal).Behaviors) 
            {
                Console.WriteLine(behavior.Key);
            }
            Console.ReadKey();
        }
    }
}
