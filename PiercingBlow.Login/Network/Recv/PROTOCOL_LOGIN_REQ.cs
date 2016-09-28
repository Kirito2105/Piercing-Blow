///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;
using PiercingBlow.Login.Manager;
using PiercingBlow.Login.Network.Send;

namespace PiercingBlow.Login.Network.Recv
{
    class PROTOCOL_LOGIN_REQ : ClientPacket
    {
        private string Login, Password;
        public override void ReadImpl()
        {
            byte[] Unk = ReadBytes(100);
            Password = ReadString();
            Login = ReadString();
            Log.Info($"Login {Login} Password {Password}");
        }

        public override void RunImpl()
        {
            var manager = AccountManager.Instance;
            Client.Account = manager.GetAccount(Login);
            Client.Player = PlayerManager.Instance.GetPlayer(Client.Account.Id);
            Client.Character = CharacterManager.Instance.GetCharacter(Client.Account.Id);
            Client.SendPacket(new PROTOCOL_LOGIN_ACK(manager.IsValidAccount(Login, Password), Client.Account));
        }
    }
}
