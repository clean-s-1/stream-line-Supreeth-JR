
namespace SteamLine.IO
{
    using SteamLine.Models;
    using System.Collections.Generic;
    using SteamLine.Utilities;

    public class IoDataProcessor : IIoDataProcessor
    {
        public List<SensorDataModel> GetSensorReadings()
        {
            string jsonData = CommonUtilities.ReadData();
            return CommonUtilities.ConvertToListModel<SensorDataModel>(jsonData);
        }
    }
}
