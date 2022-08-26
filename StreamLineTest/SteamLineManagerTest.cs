namespace StreamLineTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Moq;
    using SteamLine;
    using SteamLine.IO;
    using SteamLine.Models;

    [TestClass]
    public class SteamLineManagerTest
    {
        [TestMethod]
        public void GetSensorReadingsTest()
        {
            List<SensorDataModel> data = new List<SensorDataModel>()
            {
                new SensorDataModel()
                {
                    TemperatureSensor = 10.1f,
                    VoltageSensor = 1.1f
                }
            };
            Mock<IIoDataProcessor> dataProcessor = new Mock<IIoDataProcessor>();
            dataProcessor.Setup(x => x.GetSensorReadings()).Returns(data);
            Mock<IDataSender> dataSender = new Mock<IDataSender>();
            SteamLineManager steamLineManager = new SteamLineManager(dataSender.Object, dataProcessor.Object);
            Assert.IsFalse(steamLineManager.GetSensorData().Count == 1);
        }
    }
}
