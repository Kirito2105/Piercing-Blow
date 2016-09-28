using PiercingBlow.Commons.Utils;
using System.Xml;

namespace PiercingBlow.Cached.Config
{
    public class CachedConfig
    {
        private static readonly Logger log = Logger.Instance;
        public static string IPAddress;
        public static int Port;

        public static void Initialize()
        {
            XmlTextReader reader = new XmlTextReader(@"Data/Config/Cached.xml");
            reader.ReadToFollowing("IPAddress");
            IPAddress = reader.ReadElementContentAsString();
            reader.ReadToFollowing("Port");
            Port = reader.ReadElementContentAsInt();
        }
    }
}
