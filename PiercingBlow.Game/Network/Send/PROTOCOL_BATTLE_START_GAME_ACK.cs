using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BATTLE_START_GAME_ACK : ServerPacket
    {
        Character _chara;

        public PROTOCOL_BATTLE_START_GAME_ACK(Character chara)
        {
            _chara = chara;
        }
        public override void WriteImpl()
        {
            WriteH(0);
            WriteC(1);
            WriteC(0);
            WriteD(_chara.Character_Id);
            WriteD(_chara.WEAPON_PRIMARY);
            WriteD(_chara.WEAPON_SECONDARY);
            WriteD(_chara.WEAPON_MELEE);
            WriteD(_chara.WEAPON_THROWING);
            WriteD(_chara.WEAPON_SPECIAL);
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
            WriteB(new byte[] { 0x64, 0x64, 0x64, 0x64, 0x64 });
            WriteD(1);
            WriteB(new byte[] { 0x00, 0x03, 0xff, 0x01, 0x01, 0x00 });
            WriteB(new byte[] { 0x01, 0x00, 0x02, 0x04 });
        }
    }
}
