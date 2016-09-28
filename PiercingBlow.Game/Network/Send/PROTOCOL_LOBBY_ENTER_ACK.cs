using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_LOBBY_ENTER_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteBS("0600020C000000000000");
        }
    }
}
