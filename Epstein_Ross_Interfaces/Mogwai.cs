using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Mogwai : Animal, ITrainable
    {

        public string noise = "\"Bright light. Bright light.\"";
        public Mogwai(string species = "Mogwai", int foodConsumed = 0, string treat = "fried chicken") : base(species, foodConsumed, treat)
        {

        }

        Dictionary<string, string> ITrainable.Behaviors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string MakeNoise(string noise, string animalName = "Mogwai")
        {
            return base.MakeNoise(noise, animalName);

        }

        string ITrainable.Perform(string signal)
        {
            throw new NotImplementedException();
        }

        string ITrainable.Train(string signal, string behavior)
        {
            throw new NotImplementedException();
        }
    }
}
