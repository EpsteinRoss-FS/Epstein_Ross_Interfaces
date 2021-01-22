using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    interface ITrainable
    {
        public Dictionary<string, string> Behaviors { get; set; }
        public string Perform(string signal);
        public string Train(string signal, string behavior);



    }
}
