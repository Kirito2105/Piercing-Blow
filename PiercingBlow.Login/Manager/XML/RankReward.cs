using System.Collections.Generic;
using System.Xml.Serialization;

namespace PiercingBlow.Login.Manager.XML
{
    public class RankReward
    {
        [XmlAttribute]
        public uint Points { get; set; }
        [XmlArray("Items")]
        [XmlArrayItem("Item")]
        public List<int> Items { get; set; }

    }
}