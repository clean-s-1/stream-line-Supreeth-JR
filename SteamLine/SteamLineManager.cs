namespace SteamLine
{
    using System.Collections.Generic;
    using SteamLine.IO;
    using SteamLine.Models;

    public class SteamLineManager
    {
        private readonly IDataSender _dataSender;
        private readonly IIoDataProcessor _dataProcessor;

        public SteamLineManager(IDataSender dataSender,IIoDataProcessor dataProcessor)
        {
            _dataSender = dataSender;
            _dataProcessor = dataProcessor;
        }

        public void ManageSensors()
        {
            List<SensorDataModel> sensorReadings = _dataProcessor.GetSensorReadings();
            _dataSender.SendSensorData(sensorReadings, ReciverMethod);
        }

        private bool ReciverMethod(List<SensorDataModel> sendorData)
        {
            return true;
        }
    }
}
