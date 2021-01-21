using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Jackalope : Animal
    {
        private string _noise;

        public string Noise
        {
            get
            {
                return _noise;
            }
        }
        
        public Jackalope(string species = "Jackalope", int foodConsumed = 0, string treat = "carrots") : base(species, foodConsumed, treat)
        {
            _noise = "skibidi wap-pa-pa-pa-pa-pa-pa-pa-pa!";
        }

        public override string MakeNoise(string noise, string animalName = "Jackalope")
        {
            return base.MakeNoise(noise, animalName);
            
        }
    }

    
}
