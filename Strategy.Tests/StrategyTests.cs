using System;
using System.Configuration;
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

        [TestMethod]
        public void CheckConfigurationReaderReadsSuppliedKeyValue()
        {
            // Arrange
            var keyName = "thisIsAKey";
            var value = "value";
            ConfigurationManager.AppSettings[keyName] = value;

            // Act
            var reader = new ConfigurationReader();
            var result = reader.Read(keyName);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void CheckConnectionReaderReadsSuppliedKeyValue()
        {
            // Arrange
            var keyName = "thisIsAKey";
            var value = "value";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(keyName, value));
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

            // Act
            var reader = new ConnectionReader();
            var result = reader.Read(keyName);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(value, result);
        }
    }
}