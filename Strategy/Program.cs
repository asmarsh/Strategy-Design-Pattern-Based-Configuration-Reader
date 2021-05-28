using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var readers = new List<IConfigurationReader>() { new ConfigurationReader(), new ConnectionReader() };
            foreach (var reader in readers)
            {
                Console.WriteLine(reader.Read("value"));
            }

            Console.ReadKey();
        }
    }
}