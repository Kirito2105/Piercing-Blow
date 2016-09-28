using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Model.Chat;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_LOBBY_CHATTING_REQ : ClientPacket
    {
        ChatType _type;
        string _message;
        public override void ReadImpl()
        {
            _type = (ChatType)ReadShort();
            int lenght = ReadShort();

            if (lenght > 256)
            {
                lenght = 256;
            }

            _message = ReadStringUni(lenght * 2);

            Log.Info($"Message:{_message}");
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_LOBBY_CHATTING_ACK(Client.Player, _type, _message));
        }
    }
}
