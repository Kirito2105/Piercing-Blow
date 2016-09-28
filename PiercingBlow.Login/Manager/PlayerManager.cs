using PiercingBlow.Commons.Interface.WCF.Cached;
using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Login.Config;
using System;
using System.ServiceModel;

namespace PiercingBlow.Login.Manager
{
    public class PlayerManager : SingletonBase<PlayerManager>
    {
        private static Uri _tcpUri = new Uri("http://" + RemoteConfig.IPAddress + ":" + RemoteConfig.Port + "/IPlayerDao");
        private static EndpointAddress _address = new EndpointAddress(_tcpUri);
        private static BasicHttpBinding _binding = new BasicHttpBinding();
        private static ChannelFactory<IPlayerDao> _factory = new ChannelFactory<IPlayerDao>(_binding, _address);
        private IPlayerDao _service = _factory.CreateChannel();

        public Player GetPlayer(int accountId)
        {
            return _service.GetPlayer(accountId);
        }
    }
}
