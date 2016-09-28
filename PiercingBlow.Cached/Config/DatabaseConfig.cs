using PiercingBlow.Commons.Utils;
using System.Xml;

namespace PiercingBlow.Cached.Config
{
    public class DatabaseConfig
    {
        private static readonly Logger log = Logger.Instance;
        public static string IPAddress, Database, Username, Password;
        public static int Port;

        public static void Initialize()
        {
            XmlTextReader reader = new XmlTextReader(@"Data/Config/Database.xml");
            reader.ReadToFollowing("IPAddress");
            IPAddress = reader.ReadElementContentAsString();
            reader.ReadToFollowing("Port");
            Port = reader.ReadElementContentAsInt();
            reader.ReadToFollowing("Database");
            Database = reader.ReadElementContentAsString();
            reader.ReadToFollowing("Username");
            Username = reader.ReadElementContentAsString();
            reader.ReadToFollowing("Password");
            Password = reader.ReadElementContentAsString();
        }
    }
}
