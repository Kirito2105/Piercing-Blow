namespace PiercingBlow.Game.Model.Room
{
    public enum SlotState : byte
    {
        Empty = 0,
        Closed = 1,
        Setting = 5,
        Normal = 8,
        Ready = 9,
        Load = 10,
        PreStart = 12,
        PreBattle = 14,
        Battle = 15,
        Game = 16,
    }
}