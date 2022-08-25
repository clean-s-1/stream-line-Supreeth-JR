namespace SteamLine
{
    using SteamLine.IO;

    class Program
    {
        static void Main(string[] args)
        {
            SteamLineManager steamLineManager = new SteamLineManager(new DataSender(),new IoDataProcessor());
            steamLineManager.ManageSensors();
        }
    }
}
