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
            var factory = new ReaderFactory();
            var readers = new List<IConfigurationReader>() { factory.GetReader("ConfigurationReader"), factory.GetReader("ConnectionReader") };
            foreach (var reader in readers)
            {
                Console.WriteLine($"reading with {reader.GetType().Name}");

                Console.WriteLine(reader.Read("value"));
            }

            Console.ReadKey();
        }
    }
}