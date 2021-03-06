﻿/**
 * Ross Epstein
 * January 22nd, 2021
 * Week 3 - Interfaces
 * **/

using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Butterfly : Animal
    {
        private string _noise;

        public string Noise
        {
            get
            {
                return _noise;
            }
        }
        
        public Butterfly(string species = "Butterfly", int foodConsumed = 0, string treat = "Nectar") : base(species, foodConsumed, treat)
        {
            _noise = "\"They passed down all the roads long ago, and the Red Bull ran close behind them and covered their footsteps!\"";
        }

        public override string MakeNoise(string noise, string animalName = "Butterfly")
        {
            return base.MakeNoise(noise, animalName);

        }
    }
}
