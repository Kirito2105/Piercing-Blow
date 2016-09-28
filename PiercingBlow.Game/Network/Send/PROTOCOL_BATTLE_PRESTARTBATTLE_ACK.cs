using PiercingBlow.Commons.Network;
using System.Net;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BATTLE_PRESTARTBATTLE_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteD(1); //unk
            WriteD(0); //slotId
            //udp server
            WriteC(1);
            WriteB(IPAddress.Parse("192.168.0.28").GetAddressBytes()); //ip
            WriteH(40000); //port
            //room info
            WriteB(new byte[] { 0x3d, 0x01, 0x00, 0x00 }); //UniqueId
            WriteB(new byte[] { 0x02, 0x58, 0x00, 0x00 }); //Seed
            WriteB(new byte[]
{
    0x1b, 0x10, 0x11, 0x12, 0x21, 0x14, 0x0c, 0x16, 0x17, 0x18, 0x15, 0x1a, 0x04, 0x1c, 0x09, 0x08,
    0x1f, 0x20, 0x13, 0x22, 0x00, 0x0f, 0x02, 0x03, 0x01, 0x05, 0x06, 0x07, 0x19, 0x1d, 0x0a, 0x0b,
    0x1e, 0x0d, 0x0e,
}
); //hitParts
        }
    }
}
