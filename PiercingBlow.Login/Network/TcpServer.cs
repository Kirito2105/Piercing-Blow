using PiercingBlow.Commons.Utils;
using PiercingBlow.Login.Manager;
using System.Net;
using System.Net.Sockets;

namespace PiercingBlow.Login.Network
{
    public class TcpServer : SingletonBase<TcpServer>
    {
        private static readonly Logger Log = Logger.Instance;

        private TcpListener _server;

        private string _host;

        private int _port;

        private int _maxConnectionsCount;

        public void Initialize(string host, int port, int maxConnectionsCount)
        {
            _host = host;
            _port = port;
            _maxConnectionsCount = maxConnectionsCount;
            _server = new TcpListener(IPAddress.Parse(_host), _port);
            _server.Start();
            _server.BeginAcceptTcpClient(ClientManager.Instance.Accept, _server);

            Log.Info("Tcp server started at {0}:{1}", _host, _port);
        }

        /*                /// <summary>
                        /// Tcp server constructor
                        /// </summary>
                        /// <param name="host"></param>
                        /// <param name="port"></param>
                        /// <param name="maxConnectionsCount"></param>
                        public TcpServer(string host, int port, int maxConnectionsCount)
                        {
                            _host = host;
                            _port = port;
                            _maxConnectionsCount = maxConnectionsCount;
                        }

                        /// <summary>
                        /// Initilize service, creating threads for socket and start listening
                        /// </summary>
                        public void Initialize()
                        {
                            _server = new TcpListener(IPAddress.Parse(_host), _port);
                            _server.Start();
                            _server.BeginAcceptTcpClient(BeginAcceptTcpClient, null);

                            Log.Info("Server listen: {0}:{1}", _host, _port);
                        }

                        /// <summary>
                        /// 
                        /// </summary>
                        /// <param name="asyncResult"></param>
                        void BeginAcceptTcpClient(IAsyncResult asyncResult)
                        {
                            var client = _server.EndAcceptTcpClient(asyncResult);
                            var connection = new ClientConnection(client);
                            _sessions.Add(connection);
                            _server.BeginAcceptTcpClient(BeginAcceptTcpClient, null);
                        }*/
    }
}
