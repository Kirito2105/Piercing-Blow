using PiercingBlow.Login.Config;
using PiercingBlow.Login.Network;
using System;
using System.Diagnostics;

namespace PiercingBlow.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title=("PiercingBlow.Login");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("PiercingBlow Server\nCreate by Kirito\nStart");
            Console.ResetColor();
            NetworkConfig.Initialize();
            RemoteConfig.Initialize();
            TcpServer.Instance.Initialize(NetworkConfig.Host, NetworkConfig.Port, NetworkConfig.MaxConnectionsCount);
            GameServerService.Initialize();
            Process.GetCurrentProcess().WaitForExit();
        }
    }
}
