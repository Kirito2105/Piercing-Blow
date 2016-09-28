using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Model.Room;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_ROOM_GET_SLOTINFO_ACK : ServerPacket
    {
        SlotState _state;
        Player _player;

        public PROTOCOL_ROOM_GET_SLOTINFO_ACK(SlotState state, Player player)
        {
            _state = state;
            _player = player;
        }
        public override void WriteImpl()
        {
            WriteH(0); //UNK
            WriteC(8); //количество слотов
            for (int i = 0; i < 8; i++)
            {
                WriteC((byte)_state);         // Статус //для показа ников и старта боя нужно слать 15, но тогда не начинается бой
                WriteC(_player.Rank);
                WriteD(0);                 // Клан Ид
                WriteD(0);                 // Клан Роль
                WriteC(0);                  // Клан Ранг
                WriteC(255);                  // Клан лого 1
                WriteC(255);                  // Клан лого 2
                WriteC(255);                  // Клан лого 3
                WriteC(255);                  // Клан лого 4
                WriteC(0);                  // Премиум
                WriteD(0);                 // Купоны
                WriteB(new byte[5]);   // Инк
                WriteB(new byte[34]); // Имя клана
                WriteC(0);                 // Инк
                WriteC(225);              // Инк
            }

            WriteC(0); //Главный слот игрока
        }
    }
}
