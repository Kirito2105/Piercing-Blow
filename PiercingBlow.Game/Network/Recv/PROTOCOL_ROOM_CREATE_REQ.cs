using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_ROOM_CREATE_REQ : ClientPacket
    {
        Room room;
        public override void ReadImpl()
        {
            room = new Room();
            ReadInt(); //unk
            room.Room_Name = ReadStringUni(46); //room name
            room.MapId = ReadByte(); //map
            ReadByte(); //unk
            room.Stage4v4 = ReadByte(); // Stage4v4
            room.Type = ReadByte(); // Type
            ReadByte(); //unk
            ReadByte(); //unk
            room.slots = ReadByte(); //slot
            ReadByte(); //unk
            room.AllWeapons = ReadByte(); //103
            room.RandomMap = ReadByte();
            room.Special = ReadByte();
            ReadBytes(5); //unk
            ReadStringUni(66);
            //room.Leader.Name = ReadStringUni(66); //Leader Name
            room.KillMask = ReadByte();
            ReadByte(); // unk
            ReadByte(); // unk
            ReadByte(); // unk
            room.Limit = ReadByte();
            room.SeeConf = ReadByte();
            room.AutoBalans = ReadByte();
            ReadBytes(21);
            Log.Info($"Room_Name {room.Room_Name} MapId {room.MapId}");
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_ROOM_CREATE_ACK(room));
        }
    }
}
