namespace PiercingBlow.Commons.Model.WCF.Login
{
    public class BattleServer
    {
        public int Id { get; set; }

        public string IPAddress { get; set; }

        public int Port { get; set; }

        public int MaxConnectionsCount { get; set; }

        public int СurrentConnectionsCount { get; set; }
    }
}
