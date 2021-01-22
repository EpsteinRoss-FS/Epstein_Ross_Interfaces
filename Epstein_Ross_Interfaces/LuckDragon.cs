using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class LuckDragon : Animal, ITrainable
    {

        public Dictionary<string, string> Behaviors
        {
            get { return _behaviors; }
            set { Behaviors = value; }

        }

        public Dictionary<string, string> _behaviors { get; }

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
            _behaviors = new Dictionary<string, string>();
        }
        public override string MakeNoise(string noise, string animalName = "Luck Dragon")
        {
            return base.MakeNoise(noise, animalName);

        }

        public string Perform(string signal)
        {
            throw new NotImplementedException();
        }

        public string Train(string signal, string behavior)
        {

            Behaviors.Add(signal, behavior);
            return ($"When given the signal {signal} the Mogwai will {behavior}");
        }
    }
}
