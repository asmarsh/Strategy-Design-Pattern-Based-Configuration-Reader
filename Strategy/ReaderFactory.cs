using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class ReaderFactory
    {
        public IConfigurationReader GetReader(string readerType)
        {
            if (string.IsNullOrWhiteSpace(readerType))
            {
                return null;
            }
            if (string.Equals(readerType, "ConfigurationReader", StringComparison.OrdinalIgnoreCase))
            {
                return new ConfigurationReader();
            }
            if (string.Equals(readerType, "ConnectionReader", StringComparison.OrdinalIgnoreCase))
            {
                return new ConnectionReader();
            }

            return null;
        }
    }
}