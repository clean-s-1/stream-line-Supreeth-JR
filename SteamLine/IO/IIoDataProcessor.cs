namespace SteamLine.IO
{
    using SteamLine.Models;
    using System.Collections.Generic;

    public interface IIoDataProcessor
    {
        List<SensorDataModel> GetSensorReadings();
    }
}
