namespace SteamLine
{
    using System.Collections.Generic;
    using SteamLine.IO;
    using SteamLine.Models;
    using System;

    public class SteamLineManager
    {
        private readonly IDataSender _dataSender;
        private readonly IIoDataProcessor _dataProcessor;

        public SteamLineManager(IDataSender dataSender, IIoDataProcessor dataProcessor)
        {
            _dataSender = dataSender;
            _dataProcessor = dataProcessor;
        }

        public void ManageSensors()
        {
            List<SensorDataModel> sensorReadings = GetSensorData();
            _dataSender.SendSensorData(sensorReadings, ReciverMethod);
        }

        private bool ReciverMethod(List<SensorDataModel> sendorData)
        {
            sendorData.ForEach(x =>
            {
                Console.WriteLine(
                    $"Temperature Sensor : {x.TemperatureSensor}  -- Voltage Sensor : {x.VoltageSensor} \n");
            });
            return true;
        }

        public List<SensorDataModel> GetSensorData()
         => _dataProcessor.GetSensorReadings();
    }
}
