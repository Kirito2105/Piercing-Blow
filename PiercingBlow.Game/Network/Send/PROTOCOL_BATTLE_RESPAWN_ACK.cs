using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BATTLE_RESPAWN_ACK : ServerPacket
    {
        Character _chara;

        public PROTOCOL_BATTLE_RESPAWN_ACK(Character chara)
        {
            _chara = chara;
        }
        public override void WriteImpl()
        {
            WriteD(0);
            WriteD(0);
            WriteB(new byte[] { 0x01, 0x00, 0x00, 0x00 });
            WriteD(_chara.WEAPON_PRIMARY);
            WriteD(_chara.WEAPON_SECONDARY);
            WriteD(_chara.WEAPON_MELEE);
            WriteD(_chara.WEAPON_THROWING);
            WriteD(_chara.WEAPON_SPECIAL);
            WriteB(new byte[] { 0x64, 0x64, 0x64, 0x64, 0x64 });
            WriteD(_chara.Character_Id);
            WriteD(_chara.Character_Head);
            WriteD(_chara.Character_Face);
            WriteD(_chara.Character_Jacket);
            WriteD(_chara.Character_Poket);
            WriteD(_chara.Character_Glove);
            WriteD(_chara.Character_Belt);
            WriteD(_chara.Character_Holster);
            WriteD(_chara.Character_Skin);
            WriteD(_chara.Character_Beret);
            }
    }
}
