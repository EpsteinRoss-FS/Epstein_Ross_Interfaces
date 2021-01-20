using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Interfaces
{
    interface ITrainable
    {
        Dictionary<string, string> Behaviors { get; set; }
        string Perform(string signal);
        string Train(string signal, string behavior);
    }
}
