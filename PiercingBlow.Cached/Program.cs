using PiercingBlow.Cached.Config;
using PiercingBlow.Cached.Database;
using PiercingBlow.Cached.Database.Dao;
using System;
using System.Diagnostics;

namespace PiercingBlow.Cached
{
    class Program
    {
        static void Main(string[] args)
        {
            CachedConfig.Initialize();
            DatabaseConfig.Initialize();
            DatabaseFactory.Instance.Initialize();
            AccountDao.Initialize();
            PlayerDao.Initialize();
            CharacterDao.Initialize();
            Process.GetCurrentProcess().WaitForExit();
        }
    }
}
