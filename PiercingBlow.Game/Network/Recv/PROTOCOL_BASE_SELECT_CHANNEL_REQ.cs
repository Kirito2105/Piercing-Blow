using PiercingBlow.Commons.Manager.XML.Channel;
using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BASE_SELECT_CHANNEL_REQ : ClientPacket
    {
        int Unk;
        public override void ReadImpl()
        {
            Unk = ReadShort();
            Log.Info($"Channel:{Unk}");
        }

        public override void RunImpl()
        {
            Channel channel = ChannelSerializer.Load();
            Client.SendPacket(new PROTOCOL_BASE_SELECT_CHANNEL_ACK(channel));
        }
    }
}
