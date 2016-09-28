using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BASE_DAILY_RECORD_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteB(new byte[31]);
        }
    }
}
