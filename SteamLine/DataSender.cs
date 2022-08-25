namespace SteamLine
{
    using System;
    using System.Collections.Generic;
    using SteamLine.Models;

    public class DataSender : IDataSender
    {
        public void SendSensorData(
            List<SensorDataModel> sensorData, 
            Func<List<SensorDataModel>, bool> reciverMethod)
        {
            sensorData.ForEach(x =>
            {
                Console.WriteLine(
                    $"Temperature Sensor : {x.TemperatureSensor}  -- Voltage Sensor : {x.VoltageSensor} \n");
            });
        }
    }
}
