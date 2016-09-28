
using PiercingBlow.Commons.Manager.XML.Channel;
///
/// Create by Kirito
///
using PiercingBlow.Commons.Network;
using PiercingBlow.Login.Manager.XML;
using PiercingBlow.Login.Network.Send;

namespace PiercingBlow.Login.Network.Recv
{
    class PROTOCOL_BASE_GET_SYSTEM_INFO_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Channel channel = ChannelSerializer.Load();
            Rank rank = RankSerializer.Load();
            Client.SendPacket(new PROTOCOL_BASE_GET_SYSTEM_INFO_ACK(rank, channel));
            Client.SendPacket(new PROTOCOL_BASE_NOTICE_ACK());
            Client.SendPacket(new PROTOCOL_BASE_URL_LIST_ACK());
            Client.SendPacket(new PROTOCOL_BASE_MAP_RULELIST_ACK());
            Client.SendPacket(new PROTOCOL_BASE_MAP_MATCHINGLIST_PART_1_ACK());
            Client.SendPacket(new PROTOCOL_BASE_MAP_MATCHINGLIST_PART_2_ACK());
            Client.SendPacket(new PROTOCOL_BASE_MAP_MATCHINGLIST_PART_3_ACK());
        }
    }
}
