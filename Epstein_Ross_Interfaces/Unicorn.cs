using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Unicorn : Animal
    {
        private string _noise;

        public string Noise
        {
            get
            {
                return _noise;
            }
        }

        public Unicorn(string species = "Unicorn", int foodConsumed = 0, string treat = "Mystical Bits of Aether Essence") : base(species, foodConsumed, treat)
        {
            _noise = "\"There has never been a time without unicorns! We live forever!\nWe are as old as the sky, old as the moon!\"";

        }

        public override string MakeNoise(string Noise, string animalName = "Unicorn")
        {
            return base.MakeNoise(Noise, animalName);

        }
    }
}
