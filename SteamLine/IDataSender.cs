namespace SteamLine
{
    using System;
    using System.Collections.Generic;
    using SteamLine.Models;

    public interface IDataSender
    {
        void SendSensorData(List<SensorDataModel> sensorData,Func<List<SensorDataModel>,bool> reciverMethod);
    }
}
