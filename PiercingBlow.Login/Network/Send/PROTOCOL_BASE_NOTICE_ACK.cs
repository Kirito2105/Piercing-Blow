///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    class PROTOCOL_BASE_NOTICE_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteH(0);
            WriteD(65280); //rgb in int chat green
            WriteD(16776960); //rgb in int Announcer yellow
            WriteH(31);
            WriteAnnouncer("Приветствую на тестовом сервере", 31);
            WriteH(42);
            WriteAnnouncer("Добро пожаловать на сервер Project Gideon!", 42);
        }
    }
}