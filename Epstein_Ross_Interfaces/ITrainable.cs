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
    interface ITrainable
    {
        Dictionary<string, string> Behaviors { get; set; }
        public string Perform(string signal);
        public string Train(string signal, string behavior);



    }
}
