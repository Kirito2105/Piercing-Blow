using PiercingBlow.Commons.Model.WCF;
using PiercingBlow.Commons.Utils;
using System;
using System.Xml;

namespace PiercingBlow.Game.Config
{
    public class GameConfig
    {
        private static readonly Logger log = Logger.Instance;
        public static string IPAddress;
        public static int Port, MaxConnectionsCount, Type;
        //public static ChannelType Type;

        public static void Initialize()
        {
            XmlTextReader reader = new XmlTextReader(@"Data/Config/Game.xml");
            reader.ReadToFollowing("IPAddress");
            IPAddress = reader.ReadElementContentAsString();
            reader.ReadToFollowing("Port");
            Port = reader.ReadElementContentAsInt();
            reader.ReadToFollowing("MaxConnectionsCount");
            MaxConnectionsCount = reader.ReadElementContentAsInt();
            reader.ReadToFollowing("Type");
            Type = reader.ReadElementContentAsInt();
            //Type = (ChannelType)Enum.Parse(typeof(ChannelType), reader.ReadElementContentAsString());
        }
    }
}
