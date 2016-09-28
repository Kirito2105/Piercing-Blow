///
/// Create by Kirito
///
using PiercingBlow.Commons.Network;
using PiercingBlow.Login.Network.Send;
using PiercingBlow.Commons.Manager.XML.Channel;

namespace PiercingBlow.Login.Network.Recv
{
    class PROTOCOL_BASE_GET_CHANNELLIST_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
            int channel = ReadInt();
        }

        public override void RunImpl()
        {
            Channel channel = ChannelSerializer.Load();
            Client.SendPacket(new PROTOCOL_BASE_GET_CHANNELLIST_ACK(channel));
        }
    }
}
