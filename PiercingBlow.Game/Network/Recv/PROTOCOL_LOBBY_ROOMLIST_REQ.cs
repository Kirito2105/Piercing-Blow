using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_LOBBY_ROOMLIST_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            //Client.Character = CharacterManager.Instance.GetCharacter(Client.Account.Id);
            //Channel channel = ChannelInfoHolder.getChannel(getClient().getChannelId());
            //Client.Channel = ChannelManager.Instance.GetChannel(Client.getChannelId());
            //channel.RemoveEmptyRooms();
            //Client.SendPacket(new PROTOCOL_LOBBY_ROOMLIST_ACK(channel));
            Client.SendPacket(new PROTOCOL_LOBBY_ROOMLIST_ACK());
        }
    }
}
