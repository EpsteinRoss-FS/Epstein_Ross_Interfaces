using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Mogwai : Animal, ITrainable
    {

        private string _noise;

        public string Noise
        {
            get
            {
                return _noise;
            }
        }
        
        public Mogwai(string species = "Mogwai", int foodConsumed = 0, string treat = "fried chicken") : base(species, foodConsumed, treat)
        {
            _noise = "\"Bright light. Bright light.\"";
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
