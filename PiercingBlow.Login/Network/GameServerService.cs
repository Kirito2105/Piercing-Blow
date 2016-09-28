using PiercingBlow.Commons.Interface.WCF.Login;
using PiercingBlow.Commons.Model.WCF.Login;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Login.Config;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace PiercingBlow.Login.Network
{
    public class GameServerService : IGameServerService
    {
        private static readonly Logger Log = Logger.Instance;

        public static readonly Dictionary<int, GameServer> GameServers = new Dictionary<int, GameServer>();
        /// <summary>
        /// Initilize service
        /// </summary>
        public static void Initialize()
        {
            Uri uri = new Uri("http://" + RemoteConfig.IPAddress + ":" + RemoteConfig.Port + "/IGameServerService");
            ServiceHost host = new ServiceHost(typeof(GameServerService), uri);
            host.AddServiceEndpoint(typeof(IGameServerService), new BasicHttpBinding(), "");
            host.Open();
            Log.Info("WCF Service [{0}] successfully loaded", uri.OriginalString);
        }
        /// <summary>
        /// Add Server
        /// </summary>
        /// <param name="server"></param>
        public void AddServer(GameServer server)
        {
            GameServers.Add(server.Id, server);
            Log.Info("Server {0}:{1} has successfully connected", server.IPAddress, server.Port);
        }

        public void game(GameServer game, string IPAddress, int port, int maxConnectionsCount, int type)
        {
            game = new GameServer()
            {
                Id = GetServers().Count,
                IPAddress = IPAddress,
                Port = port,
                MaxConnectionsCount = maxConnectionsCount,
                Type = type,
            };
        }
        /// <summary>
        /// Get Servers
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, GameServer> GetServers()
        {
            return GameServers;
        }
    }
}
