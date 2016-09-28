using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BATTLE_DEATH_REQ : ClientPacket
    {
        FragInfo fraginfo;
        public override void ReadImpl()
        {
            fraginfo = new FragInfo();
            fraginfo.KillingType = ReadByte();
            fraginfo.Count = ReadByte();
            fraginfo.SlotId = ReadByte();
            fraginfo.WeaponId = ReadInt();
            fraginfo.X = ReadInt();
            fraginfo.Y = ReadInt();
            fraginfo.Z = ReadInt();
            fraginfo.Flag = ReadByte();
            for (int i = 0; i < fraginfo.Count;i++)
            {
                byte[] Unk = ReadBytes(18);
            }
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BATTLE_DEATH_ACK(fraginfo));
        }
    }
}
