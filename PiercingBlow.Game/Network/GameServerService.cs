using PiercingBlow.Commons.Interface.WCF.Login;
using PiercingBlow.Commons.Model.WCF.Login;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Game.Config;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace PiercingBlow.Game.Network
{
    public class GameServerService
    {
        private static Logger Log = Logger.Instance;

        private static Uri _tcpUri = new Uri("http://" + RemoteConfig.IPAddress + ":" + RemoteConfig.Port + "/IGameServerService");
        private static EndpointAddress _address = new EndpointAddress(_tcpUri);
        private static BasicHttpBinding _binding = new BasicHttpBinding();
        private static ChannelFactory<IGameServerService> _factory = new ChannelFactory<IGameServerService>(_binding, _address);
        private static IGameServerService _service = _factory.CreateChannel();

        public static GameServer Server { get; set; }

        /// <summary>
        /// Initilize service
        /// </summary>
        public static void Initialize(string IPAddress, int port, int maxConnectionsCount)
        {
            Server = new GameServer()
            {
                Id = GetServers().Count,
                IPAddress = IPAddress,
                Port = port,
                MaxConnectionsCount = maxConnectionsCount,
            };
            _service.AddServer(Server);
        }

        /// <summary>
        /// Get Servers
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, GameServer> GetServers()
        {
            return _service.GetServers();
        }

        /// <summary>
        /// Set current connections count
        /// </summary>
        /// <param name="currentConnectionsCount"></param>
        public void SetServer(int currentConnectionsCount)
        {
            _service.GetServers()[Server.Id].СurrentConnectionsCount = currentConnectionsCount;
        }
    }
}
