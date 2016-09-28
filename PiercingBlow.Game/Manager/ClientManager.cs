using PiercingBlow.Commons.Utils;
using PiercingBlow.Game.Network;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;

namespace PiercingBlow.Game.Manager
{
    public class ClientManager : SingletonBase<ClientManager>
    {
        private static readonly Logger Log = Logger.Instance;

        static readonly Dictionary<int, ClientConnection> _sessions = new Dictionary<int, ClientConnection>();

        static int _sessionId = 0;

        /// <summary>
        /// Accept new client
        /// </summary>
        /// <param name="arg"></param>
        public void Accept(IAsyncResult arg)
        {
            TcpListener listener = arg.AsyncState as TcpListener;
            TcpClient client = listener.EndAcceptTcpClient(arg);

            Connected(client);

            listener.BeginAcceptTcpClient(Accept, listener);
        }

        /// <summary>
        /// Connected client
        /// </summary>
        /// <param name="client"></param>
        static void Connected(TcpClient client)
        {
            Interlocked.Increment(ref _sessionId);


            ClientConnection session = new ClientConnection()
            {
                Id = _sessionId
            };

            session.Accept(client);
            session.OnDisconnected += Disconnected;

            _sessions.Add(session.Id, session);


            Log.Info("New client session #{0} is connected.", session.Id);
        }

        /// <summary>
        /// Disconnected client
        /// </summary>
        /// <param name="session"></param>
        static void Disconnected(ClientConnection session)
        {
            session.OnDisconnected -= Disconnected;

            session.Stream.Close();
            session.Client.Close();


            _sessions.Remove(session.Id);


            Log.Info("Client session #{0} disconnected from server.", session.Id);


            session = null;
        }
    }
}
