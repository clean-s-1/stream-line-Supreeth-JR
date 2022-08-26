namespace SteamLine.Utilities
{
    using System.IO;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public static class CommonUtilities
    {
        public static string ReadData()
        {
            using (StreamReader reader = new StreamReader(".\\SensorReadings.json"))
            {
                string jsonData = reader.ReadToEnd();
                return jsonData;
            }
        }
        public static List<T> ConvertToListModel<T>(string data) where T : new()
        {
            return JsonConvert.DeserializeObject<List<T>>(data);
        }
    }
}
