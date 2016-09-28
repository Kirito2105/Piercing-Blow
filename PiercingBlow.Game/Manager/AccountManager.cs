using PiercingBlow.Commons.Interface.WCF.Cached;
using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Game.Config;
using System;
using System.ServiceModel;

namespace PiercingBlow.Game.Manager
{
    public class AccountManager : SingletonBase<AccountManager>
    {
        private static Uri _tcpUri = new Uri("http://" + RemoteConfig.IPAddress + ":" + RemoteConfig.Port + "/IAccountDao");
        private static EndpointAddress _address = new EndpointAddress(_tcpUri);
        private static BasicHttpBinding _binding = new BasicHttpBinding();
        private static ChannelFactory<IAccountDao> _factory = new ChannelFactory<IAccountDao>(_binding, _address);
        private IAccountDao _service = _factory.CreateChannel();


        public Account GetAccount(string login)
        {
            return _service.GetAccount(login);
        }
    }
}
