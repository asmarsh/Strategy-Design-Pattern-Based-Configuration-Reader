using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConfigurationReader : IConfigurationReader
    {
        public string Read(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}