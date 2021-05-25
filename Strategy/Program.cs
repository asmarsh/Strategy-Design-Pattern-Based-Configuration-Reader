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
            IConfigurationReader reader = new ConfigurationReader();
            string value = reader.Read("ABC");
            Console.WriteLine($"ABC=>{value}");
            reader = new ConnectionReader();
            value = reader.Read("db");
            Console.WriteLine($"db=>{value}");

            Console.ReadKey();
        }
    }
}