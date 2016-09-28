using PiercingBlow.Commons.Interface.WCF.Cached;
using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Model.Enum.Login;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Login.Config;
using System;
using System.ServiceModel;

namespace PiercingBlow.Login.Manager
{
    public class AccountManager : SingletonBase<AccountManager>
    {
        private static Uri _tcpUri = new Uri("http://" + RemoteConfig.IPAddress + ":" + RemoteConfig.Port + "/IAccountDao");
        private static EndpointAddress _address = new EndpointAddress(_tcpUri);
        private static BasicHttpBinding _binding = new BasicHttpBinding();
        private static ChannelFactory<IAccountDao> _factory = new ChannelFactory<IAccountDao>(_binding, _address);
        private IAccountDao _service = _factory.CreateChannel();

        public LoginState IsValidAccount(string login, string password)
        {
            return _service.IsValidAccount(login, password);
        }

        public Account GetAccount(string login)
        {
            return _service.GetAccount(login);
        }
    }
}
