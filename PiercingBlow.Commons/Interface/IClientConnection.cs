using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;
using System;

namespace PiercingBlow.Commons.Interface
{
    public interface IClientConnection
    {
        int Id { get; set; }
        byte[] RemoteIPAddress { get; set; }
        int RemoteUdpPort { get; set; }

        Account Account { get; set; }

        Player Player { get; set; }
        Character Character { get; set; }

        void BeginRead(IAsyncResult asyncResult);
        void SendPacket(ServerPacket packet);
    }
}
