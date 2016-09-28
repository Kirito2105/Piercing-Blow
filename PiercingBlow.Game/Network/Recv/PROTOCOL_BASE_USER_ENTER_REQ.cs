using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Manager;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BASE_USER_ENTER_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
            int length = ReadByte();
            string Login = ReadString(length);
            Client.Account = AccountManager.Instance.GetAccount(Login);
            Client.Player = PlayerManager.Instance.GetPlayer(Client.Account.Id);
            Client.Character = CharacterManager.Instance.GetCharacter(Client.Account.Id);
            Log.Info($"Login {Login}");
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BASE_USER_ENTER_ACK());
        }
    }
}
