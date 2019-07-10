﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimBaseNetCore20.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class ScriptAfterPartialViewAttribute:Attribute
    {
        public readonly string ScriptToRun;
        public ScriptAfterPartialViewAttribute(string scriptoRun)  // What script to run after loading a partial view
        {
            this.ScriptToRun = scriptoRun;
        }
    }
}
