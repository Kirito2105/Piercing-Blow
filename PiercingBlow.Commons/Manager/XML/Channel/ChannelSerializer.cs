using PiercingBlow.Commons.Utils;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace PiercingBlow.Commons.Manager.XML.Channel
{
    public class ChannelSerializer
    {
        private static readonly Logger Log = Logger.Instance;
        public static Channel Load()
        {
            using (var reader = XmlReader.Create("Data\\Xml\\Channel.xml"))
            {
                var serializer = new XmlSerializer(typeof(Channel), new XmlRootAttribute("ChannelData"));
                try
                {
                    var ChannelObject = (Channel)serializer.Deserialize(reader);
                    return ChannelObject;
                }
                catch (Exception ex)
                {
                    Log.Error($"{ex.Message}\n{ex.StackTrace}");
                }
            }
            return null;
        }
    }
}
