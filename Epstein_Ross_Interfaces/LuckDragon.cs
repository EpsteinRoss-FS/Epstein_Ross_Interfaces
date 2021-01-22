using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class LuckDragon : Animal, ITrainable
    {
        private string _noise;

        public string Noise
        {
            get
            {
                return _noise;
            }
        }
        public LuckDragon(string species = "Luck Dragon", int foodConsumed = 0, string treat = "Something, but never children!") : base(species, foodConsumed, treat)
        {
            _noise = "\"Never give up and good luck will find you.\"";
        }
        public override string MakeNoise(string noise, string animalName = "Luck Dragon")
        {
            return base.MakeNoise(noise, animalName);

        }

        Dictionary<string, string> ITrainable.Behaviors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
