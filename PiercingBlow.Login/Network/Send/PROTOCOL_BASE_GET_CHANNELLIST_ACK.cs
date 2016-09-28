///
/// Create by Kirito
///
using PiercingBlow.Commons.Manager.XML.Channel;
using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    public class PROTOCOL_BASE_GET_CHANNELLIST_ACK : ServerPacket
    {
        Channel _channel;
        public PROTOCOL_BASE_GET_CHANNELLIST_ACK(Channel channel)
        {
            _channel = channel;
        }
        public override void WriteImpl()
        {
            WriteB(new byte[] { 0x04, 0x25 });
            WriteC(0);
            WriteC(10);
            for(int i = 0; i < 10; i++)
            {
                WriteH(100);
            }
            WriteH(300);
            WriteC(10);
        }
    }
}