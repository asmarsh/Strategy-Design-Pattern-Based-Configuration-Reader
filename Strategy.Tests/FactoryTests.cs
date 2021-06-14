using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strategy.Tests
{
    [TestClass]
    public class FactoryTests
    {
        [DataTestMethod]
        [DataRow("configurationreader"), DataRow("CONFIGURATIONREADER"), DataRow("ConfigurationReader")]
        public void CheckReaderFactoryReturnsConfigurationReader(string readerType)
        {
            var factory = new ReaderFactory();

            var reader = factory.GetReader(readerType);

            Assert.IsInstanceOfType(reader, typeof(ConfigurationReader));
        }

        [DataTestMethod]
        [DataRow("connectionreader"), DataRow("CONNECTIONREADER"), DataRow("ConnectionReader")]
        public void CheckReaderFactoryReturnsConnectionReader(string readerType)
        {
            var factory = new ReaderFactory();

            var reader = factory.GetReader(readerType);

            Assert.IsInstanceOfType(reader, typeof(ConnectionReader));
        }

        [DataTestMethod]
        [DataRow("ConfigReader"), DataRow(""), DataRow("Other")]
        public void CheckReaderFactoryReturnsNullForInvalidInout(string readerType)
        {
            var factory = new ReaderFactory();

            var reader = factory.GetReader(readerType);

            Assert.IsNotInstanceOfType(reader, typeof(ConfigurationReader));
            Assert.IsNotInstanceOfType(reader, typeof(ConnectionReader));
        }
    }
}