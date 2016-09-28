using PiercingBlow.Game.Config;
using PiercingBlow.Game.Network;
using System;
using System.Diagnostics;

namespace PiercingBlow.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("PiercingBlow.Game");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("PiercingBlow Server\nCreate by Kirito\nStart");
            GameConfig.Initialize();
            RemoteConfig.Initialize();
            TcpServer.Instance.Initialize(GameConfig.IPAddress, GameConfig.Port, GameConfig.MaxConnectionsCount);
            GameServerService.Initialize(GameConfig.IPAddress, GameConfig.Port, GameConfig.MaxConnectionsCount);
            Process.GetCurrentProcess().WaitForExit();
        }
    }
}
