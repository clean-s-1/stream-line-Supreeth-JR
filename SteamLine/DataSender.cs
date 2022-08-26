namespace SteamLine
{
    using System;
    using System.Collections.Generic;
    using SteamLine.Models;

    public class DataSender : IDataSender
    {
        public void SendSensorData(
            List<SensorDataModel> sensorData, 
            Func<List<SensorDataModel>,bool> reciverMethod)
        {
            reciverMethod.Invoke(sensorData);
        }
    }
}
