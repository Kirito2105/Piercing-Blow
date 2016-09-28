using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_SHOP_GET_SAILLIST_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
            byte[] Unk = ReadBytes(32);
            Log.Info($"Shop {Unk}");
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_SHOP_GET_SAILLIST_ACK());
        }
    }
}
