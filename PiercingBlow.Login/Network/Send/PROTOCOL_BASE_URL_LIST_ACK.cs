using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    public class PROTOCOL_BASE_URL_LIST_ACK : ServerPacket
    {
        public PROTOCOL_BASE_URL_LIST_ACK()
        { }

        public override void WriteImpl()
        {
            WriteB(new byte[] {
                0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            });
            WriteUnicode("http://in.fps-pb.com/ccn/banner/index.do", 256 * 2);
        }
    }
}
