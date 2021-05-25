using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strategy.Tests
{
    [TestClass]
    public class StrategyTests
    {
        [TestMethod]
        public void CheckConfigurationReaderReadsRelevantConfigurationSetting()
        {
            var reader = new ConfigurationReader();
            var result = reader.Read("test");

            Assert.IsNotNull(result);
            Assert.AreEqual("testResultOne", result);
        }

        [TestMethod]
        public void CheckConnectionReaderReadsRelevantConnectionString()
        {
            var reader = new ConnectionReader();
            var result = reader.Read("test");

            Assert.IsNotNull(result);
            Assert.AreEqual("testResultTwo", result);
        }
    }
}