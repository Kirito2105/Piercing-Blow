///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;
using PiercingBlow.Login.Network.Send;

namespace PiercingBlow.Login.Network.Recv
{
    class PROTOCOL_BASE_GET_MAP_INFO_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
            base.ReadImpl();
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BASE_MAP_RULELIST_ACK());
            Client.SendPacket(new PROTOCOL_BASE_MAP_MATCHINGLIST_PART_1_ACK());
            //Client.SendPacket(new PROTOCOL_BASE_MAP_MATCHINGLIST_PART_2_ACK());
            //Client.SendPacket(new PROTOCOL_BASE_MAP_MATCHINGLIST_PART_3_ACK());
        }
    }
}
