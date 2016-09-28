using PiercingBlow.Commons.Model;
using System.Xml.Serialization;

namespace PiercingBlow.Commons.Manager.XML.Channel
{
    public class Channel
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public int Type { get; set; }

        [XmlAttribute]
        public int MaxPlayer { get; set; }

        [XmlAttribute]
        public int OnlinePlayer { get; set; }
    }
}
