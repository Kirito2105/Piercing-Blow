using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Game.Model.Chat;

namespace PiercingBlow.Game.Network.Send
{
    public class PROTOCOL_LOBBY_CHATTING_ACK : ServerPacket
    {
        Player _player;
        ChatType _type;
        string _message;
        public PROTOCOL_LOBBY_CHATTING_ACK(Player player, ChatType type, string message)
        {
            _player = player;
            _type = type;
            _message = message;
        }

        public override void WriteImpl()
        {
            Logger.Instance.Info("Message:{0}, Name:{1}", _message, _player.Name);
            WriteD(_player.Id);
            WriteC(_player.Name.Length + 1);
            WriteAnnouncer(_player.Name, _player.Name.Length + 2);
            WriteC(_player.ColorName); //player color
            WriteC((byte)_type); //type
            WriteH(_message.Length);
            WriteAnnouncer(_message, _message.Length);
            /*
            Write<int>(player.Id);
            Write<byte>(player.Name.Length);
            WriteUnicode(player.Name);
            Write<byte>(player.Color);
            Write<byte>(type);
            Write<ushort>(text.Length);
            WriteUnicode(text);

            WriteB(new byte[]
{
    0x0c, 0x09, 0x00, 0x00, 0x0b, 0x47, 0x00, 0x69, 0x00, 0x64, 0x00, 0x65, 0x00, 0x6f, 0x00, 0x6e,
    0x00, 0x63, 0x00, 0x68, 0x00, 0x69, 0x00, 0x6b, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00, 0x57,
    0x00, 0x65, 0x00, 0x6c, 0x00, 0x63, 0x00, 0x6f, 0x00, 0x6d, 0x00, 0x65, 0x00, 0x20, 0x00, 0x74,
    0x00, 0x6f, 0x00, 0x20, 0x00, 0x2a, 0x00, 0x2a, 0x00, 0x2a, 0x00, 0x65, 0x00, 0x21, 0x00, 0x00,
    0x00
});
*/
        }
    }
}
