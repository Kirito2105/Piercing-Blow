using PiercingBlow.Commons.Utils;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace PiercingBlow.Login.Manager.XML
{
    public class RankSerializer
    {
        private static readonly Logger Log = Logger.Instance;
        public static Rank Load()
        {
            using (var reader = XmlReader.Create("Data\\Xml\\Rank.xml"))
            {
                var serializer = new XmlSerializer(typeof(Rank), new XmlRootAttribute("RankUpData"));
                try
                {
                    var RankObject = (Rank)serializer.Deserialize(reader);
                    return RankObject;
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