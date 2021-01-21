using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Butterfly : Animal
    {
        public string noise = "They passed down all the roads long ago, and the Red Bull ran close behind them and covered their footsteps!";
        public Butterfly(string species = "Butterfly", int foodConsumed = 0, string treat = "Nectar") : base(species, foodConsumed, treat)
        {

        }

        public override string MakeNoise(string noise, string animalName = "Jackalope")
        {
            return base.MakeNoise(noise, animalName);

        }
    }
}
