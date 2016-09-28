///
/// Create by Kirito
///

using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Model.Enum.Login;
using PiercingBlow.Commons.Network;
using PiercingBlow.Commons.Utils;

namespace PiercingBlow.Login.Network.Send
{
    class PROTOCOL_LOGIN_ACK : ServerPacket
    {
        Account _account;
        LoginState _state;

        public PROTOCOL_LOGIN_ACK(LoginState state, Account account)
        {
            _state = state;
            _account = account;
        }
        public override void WriteImpl()
        {
            Logger.Instance.Info("Status = {0}", _state);            
            WriteB(new byte[15]);
            string id = _account.Id.ToString();
            WriteC(id.Length);
            WriteS(id, id.Length);
            WriteC(0);
            WriteC(_account.Login.Length);
            WriteS(_account.Login);
            WriteQ(_account.Id);
            WriteD((int)_state);
        }
    }
}
