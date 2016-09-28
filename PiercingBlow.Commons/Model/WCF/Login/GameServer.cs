namespace PiercingBlow.Commons.Model.WCF.Login
{
    public class GameServer
    {
        public int Id { get; set; }

        public string IPAddress { get; set; }

        public int Port { get; set; }

        public int MaxConnectionsCount { get; set; }

        public int СurrentConnectionsCount { get; set; }

        public int Type { get; set; }
    }
}
