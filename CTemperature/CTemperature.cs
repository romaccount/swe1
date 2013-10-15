﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmbeddedSensorCloud;

namespace CTemperature
{
    public class CTemperature : IPlugin
    {
        private string _pluginName = "TemperaturePlugin";
        public void Load()
        {
            Console.WriteLine(_pluginName + " loaded");
        }

        public void doSomething()
        {
            Console.WriteLine(_pluginName + " did something");
        }

        public void Clean()
        {
            Console.WriteLine("cleaned " + _pluginName);
        }

        public string PluginName
        {
            get
            {
                return this._pluginName;
            }
        }
    }
}