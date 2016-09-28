using PiercingBlow.Commons.Manager.XML.Channel;
using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BASE_SELECT_CHANNEL_ACK : ServerPacket
    {
        Channel _channel;
        public PROTOCOL_BASE_SELECT_CHANNEL_ACK(Channel channel)
        {
            _channel = channel;
        }
        public override void WriteImpl()
        {
            WriteD(0);
            WriteD(0);
            WriteH(_channel.Id);
        }
    }
}
