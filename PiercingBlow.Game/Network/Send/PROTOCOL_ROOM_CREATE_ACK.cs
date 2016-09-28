using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_ROOM_CREATE_ACK : ServerPacket
    {
        Room _room;
        public PROTOCOL_ROOM_CREATE_ACK(Room room)
        {
            _room = room;
        }

        public override void WriteImpl()
        {
            WriteD(_room.RoomId);
            WriteD(_room.RoomId);
            WriteUnicode(_room.Room_Name, 23 * 2);
            WriteC(_room.MapId);
            WriteC(0); //UNK
            WriteC(_room.Stage4v4);
            WriteC(_room.Type);
            WriteC(0); // Players in room
            WriteC(1); //UNK
            WriteC(_room.slots);
            WriteC(_room.Ping);
            WriteC(_room.AllWeapons);
            WriteC(_room.RandomMap);
            WriteC(_room.Special);
            WriteB(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00 });
            WriteUnicode("GM!Kirito", 33 * 2);
            //WriteUnicode(_room.Leader.Name, 33 * 2);
            WriteC(_room.KillMask);
            WriteC(0); //UNK
            WriteC(0); //UNK
            WriteC(0); //UNK
            WriteC(_room.Limit);
            WriteC(_room.SeeConf);
            WriteH(_room.AutoBalans);
            WriteB(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, });
        }
    }
}
