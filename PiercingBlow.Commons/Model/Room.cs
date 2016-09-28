using PiercingBlow.Commons.Model.Enum.Game;
using PiercingBlow.Commons.Model.Enum.Player;

namespace PiercingBlow.Commons.Model
{
    public class Room
    {
        public static int Room_Name_Size = 46;
        public static int Room_Password_Size = 8;

        public static int[] TIMES = new int[] { 3, 5, 7, 5, 10, 15, 20, 25, 30 };
        public static int[] KILLS = new int[] { 60, 80, 100, 120, 140, 160 };
        public static int[] ROUNDS = new int[] { 0, 3, 5, 7, 9 };
        public static int[] RED_TEAM = new int[] { 0, 2, 4, 6, 8, 10, 12, 14 };
        public static int[] BLUE_TEAM = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
       // private RoomSlot[] ROOM_SLOT = new RoomSlot[16];


        public string Room_Name;
        public int RoomId;
        public int MapId;
        public int Stage4v4;
        public int Type;
        public int slots;
        public int AllWeapons;
        public int RandomMap;
        public int Special;
        public int Ping;
        public int KillMask;
        public Player Leader;
        public int Limit;
        public int SeeConf;
        public int AutoBalans;
        public string password = "";

        public int _channelId;

        private int _redKills = 0;
        private int _redDeaths = 0;
        private int _blueKills = 0;
        private int _blueDeaths = 0;

        public int _aiCount = 1;
        public int _aiLevel = 0;

        private ROOM_STATE _room_state;

        public int getRoomId()
        {
            return RoomId;
        }
    }
}
