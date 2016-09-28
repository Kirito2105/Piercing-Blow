using PiercingBlow.Commons.Utils;
using PiercingBlow.Game.Manager;
using System.Net;
using System.Net.Sockets;

namespace PiercingBlow.Game.Network
{
    public class TcpServer : SingletonBase<TcpServer>
    {
        private static readonly Logger log = Logger.Instance;

        private TcpListener _server;

        private string _host;

        private int _port;

        private int _maxConnectionsCount;

        /// <summary>
        /// Initilize service, creating threads for socket and start listening
        /// </summary>
        public void Initialize(string host, int port, int maxConnectionsCount)
        {
            _host = host;
            _port = port;
            _maxConnectionsCount = maxConnectionsCount;
            _server = new TcpListener(IPAddress.Parse(_host), _port);
            _server.Start();
            _server.BeginAcceptTcpClient(ClientManager.Instance.Accept, _server);

            log.Info("Tcp server started at {0}:{1}", _host, _port);
        }
    }
}
