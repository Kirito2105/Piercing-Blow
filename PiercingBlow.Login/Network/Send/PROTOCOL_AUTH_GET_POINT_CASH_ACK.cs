///
/// Create by Kirito
///

using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    class PROTOCOL_AUTH_GET_POINT_CASH_ACK : ServerPacket
    {
        Player _player;
        public PROTOCOL_AUTH_GET_POINT_CASH_ACK(Player player)
        {
            _player = player;
        }
        public override void WriteImpl()
        {
            WriteD(0); //unk
            WriteD(_player.Points);
            WriteD(_player.Cash);
        }
    }
}
#region Structure Packet
/*
Struct.AddInt("Unknown");
Struct.AddInt("Point");
Struct.AddInt("Cash");
*/
#endregion