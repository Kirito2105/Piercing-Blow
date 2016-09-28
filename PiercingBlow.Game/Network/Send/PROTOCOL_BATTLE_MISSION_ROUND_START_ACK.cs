using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BATTLE_MISSION_ROUND_START_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteC(1);
            WriteD(300);
            WriteH(2);
            WriteC(0);
        }
    }
}
