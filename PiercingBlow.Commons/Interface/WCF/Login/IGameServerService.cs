using PiercingBlow.Commons.Model.WCF.Login;
using System.Collections.Generic;
using System.ServiceModel;

namespace PiercingBlow.Commons.Interface.WCF.Login
{
    [ServiceContract]
    public interface IGameServerService
    {
        [OperationContract]
        void AddServer(GameServer server);
        [OperationContract]
        Dictionary<int, GameServer> GetServers();
        [OperationContract]
        void game(GameServer game, string IPAddress, int port, int maxConnectionsCount, int type);
    }
}
