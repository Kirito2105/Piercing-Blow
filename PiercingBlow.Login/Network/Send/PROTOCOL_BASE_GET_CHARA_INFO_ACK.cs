///
/// Create by Kirito
///

using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    class PROTOCOL_BASE_GET_CHARA_INFO_ACK : ServerPacket
    {
        Player _player;
        Character _chara;

        public PROTOCOL_BASE_GET_CHARA_INFO_ACK(Character chara, Player player)
        {
            _player = player;
            _chara = chara;
        }
        public override void WriteImpl()
        {
            WriteH(0);
            WriteC(_player.CountChara);
                for (int i = 0; i < 1; i++)
            {
                WriteC(_chara.CharaSlot);
                WriteBS("14610A0400");
                WriteB(new byte[] {
    0xff, 0x6e, 0xca, 0x5f,
            });
                WriteD(0);
                WriteD(0);
                WriteUnicode(_chara.Name, 33 * 2);
                WriteD(_chara.WEAPON_PRIMARY); //5C9201005C920140 (105123)
                WriteD(_chara.WEAPON_PRIMARY + 40);
                WriteD(_chara.WEAPON_SECONDARY); //1315030013150340 (202036)
                WriteD(_chara.WEAPON_SECONDARY + 40);
                WriteD(_chara.WEAPON_MELEE); //C9970400C9970440 (301001)
                WriteD(_chara.WEAPON_MELEE + 40);
                WriteD(_chara.WEAPON_THROWING); //D9350600D9350640 (407001)
                WriteD(_chara.WEAPON_THROWING + 40);
                WriteD(_chara.WEAPON_SPECIAL); //61C0070061C00740 (508001)
                WriteD(_chara.WEAPON_SPECIAL + 40);
                WriteD(_chara.Character_Id); //AB2B0900AB2B0940 (601003)
                WriteD(_chara.Character_Id + 40);
                WriteD(_chara.Character_Head); //6078A53B07000040 (701006)
                WriteD(_chara.Character_Head + 40);
                WriteD(_chara.Character_Face); //00FFA63B08000040 (800043)
                WriteD(_chara.Character_Face + 40);
                WriteD(_chara.Character_Jacket); //A085A83B09000040 (900008)
                WriteD(_chara.Character_Jacket + 40);
                WriteD(_chara.Character_Poket); //400CAA3B0A000040 (1000007)
                WriteD(_chara.Character_Poket + 40);
                WriteD(_chara.Character_Glove); //E092AB3B0B000040 (1100003)
                WriteD(_chara.Character_Glove + 40);
                WriteD(_chara.Character_Belt); //8019AD3B0C000040 (1200006)
                WriteD(_chara.Character_Belt + 40);
                WriteD(_chara.Character_Holster); //20A0AE3B0D000040 (1300006)
                WriteD(_chara.Character_Holster + 40);
                WriteD(_chara.Character_Skin); //906815000E2C2000 (1403024)  
                WriteD(_chara.Character_Skin + 40);
                WriteD(_chara.Character_Beret); //0000000000000000
                WriteD(_chara.Character_Beret);
                WriteB(new byte[] { 0x01, 0xff, 0xff, 0xff, 0x00, 0x00 });
                WriteC(0);
            }
            WriteC(0);
        }
    }
}