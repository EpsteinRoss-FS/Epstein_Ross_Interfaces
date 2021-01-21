using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class ET : Animal, ITrainable
    {
        private string _noise;

        public string Noise
        {
            get
            {
                return _noise;
            }
        }
        
        public ET(string species = "E.T.", int foodConsumed = 0, string treat = "Reese's Pieces") : base(species, foodConsumed, treat)
        {
            _noise = "\"ET...Phone...Home....\"";
        }

        Dictionary<string, string> ITrainable.Behaviors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string MakeNoise(string noise, string animalName = "E.T.")
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
