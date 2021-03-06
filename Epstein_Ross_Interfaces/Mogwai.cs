﻿/**
 * Ross Epstein
 * January 22nd, 2021
 * Week 3 - Interfaces
 * **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    class Mogwai : Animal, ITrainable
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
        
        

        public Mogwai(string species = "Mogwai", int foodConsumed = 0, string treat = "fried chicken") : base(species, foodConsumed, treat)
        {
            _noise = "\"Bright light. Bright light.\"";
            _behaviors = new Dictionary<string, string>();
        }

        //Dictionary<string, string> ITrainable.Behaviors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string MakeNoise(string noise, string animalName = "Mogwai")
        {
            return base.MakeNoise(noise, animalName);

        }

        public string Perform(string signal)
        {
            foreach (var behavior in Behaviors.Keys) 
            {
                if (behavior.ToLower() == signal.ToLower()) 
                {
                    var behaviorFound = Behaviors.Single(x => x.Key == signal);
                    return ($"The Mogwai gets the signal {behaviorFound.Key} and {behaviorFound.Value}");
                }

            }
            return ($"The Mogwai doesn't understand the signal {signal}");
        }

        public string Train(string signal, string behavior)
        {

            Behaviors.Add(signal, behavior);            
            return ($"When given the signal {signal} the Mogwai will {behavior}");
        }

    }
}
