using PiercingBlow.Commons.Interface.WCF.Cached;
using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Game.Config;
using System;
using System.ServiceModel;

namespace PiercingBlow.Game.Manager
{
    public class CharacterManager : SingletonBase<CharacterManager>
    {
        private static Uri _tcpUri = new Uri("http://" + RemoteConfig.IPAddress + ":" + RemoteConfig.Port + "/ICharacterDao");
        private static EndpointAddress _address = new EndpointAddress(_tcpUri);
        private static BasicHttpBinding _binding = new BasicHttpBinding();
        private static ChannelFactory<ICharacterDao> _factory = new ChannelFactory<ICharacterDao>(_binding, _address);
        private ICharacterDao _service = _factory.CreateChannel();

        public Character GetCharacter(int accountId)
        {
            return _service.GetCharacter(accountId);
        }
    }
}
