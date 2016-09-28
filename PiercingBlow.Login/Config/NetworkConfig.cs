using System.Xml;

namespace PiercingBlow.Login.Config
{
    public class NetworkConfig
    {
        public static string Host;
        public static int Port, MaxConnectionsCount;

        public static void Initialize()
        {
            XmlTextReader reader = new XmlTextReader(@"Data/Config/Login.xml");
            reader.ReadToFollowing("Host");
            Host = reader.ReadElementContentAsString();
            reader.ReadToFollowing("Port");
            Port = reader.ReadElementContentAsInt();
            reader.ReadToFollowing("MaxConnectionsCount");
            MaxConnectionsCount = reader.ReadElementContentAsInt();
        }
    }
}
