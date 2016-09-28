using System.Collections.Generic;
using System.Xml.Serialization;

namespace PiercingBlow.Login.Manager.XML
{
    public class Rank
    {
        [XmlAttribute]
        public uint Id { get; set; }
        [XmlAttribute]
        public string Title { get; set; }
        [XmlAttribute]
        public uint ToNextLevel { get; set; }
        [XmlAttribute]
        public uint RequiredExp { get; set; }
        public RankReward Reward { get; set; }
        [XmlElement("Rank")]
        public List<Rank> Ranks;
    }
}