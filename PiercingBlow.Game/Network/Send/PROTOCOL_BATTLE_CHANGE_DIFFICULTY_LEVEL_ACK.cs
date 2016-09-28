using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    public class PROTOCOL_BATTLE_CHANGE_DIFFICULTY_LEVEL_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteC(1); //Уровень ботов
            for (int i = 0; i < 16; i++)
                WriteD(1); //Звание ботов?
        }
    }
}
