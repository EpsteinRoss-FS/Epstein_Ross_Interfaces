using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Unicorn : Animal
    {
        public string noise = "\"There has never been a time without unocrns! We live forever!\nWe are as old as the sky, old as the moon!\"";
        public Unicorn(string species = "Unicorn", int foodConsumed = 0, string treat = "Mystical Bits of Aether Essence") : base(species, foodConsumed, treat)
        {

        }

        public override string MakeNoise(string noise, string animalName = "Unicorn")
        {
            return base.MakeNoise(noise, animalName);

        }
    }
}
