using MySql.Data.MySqlClient;
using PiercingBlow.Cached.Config;
using PiercingBlow.Commons.Utils;
using System;

namespace PiercingBlow.Cached.Database
{
    class DatabaseFactory : SingletonBase<DatabaseFactory>
    {
        private static readonly Logger Log = Logger.Instance;

        public MySqlConnection conn;
        /// <summary>
        /// Initilize service
        /// </summary>
        public void Initialize()
        {
            try
            {
                conn = new MySqlConnection("server=" + DatabaseConfig.IPAddress + ";port=" + DatabaseConfig.Port + ";database=" + DatabaseConfig.Database + ";username=" + DatabaseConfig.Username + ";password=" + DatabaseConfig.Password);
                conn.Open();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[Info] Database successfully loaded");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Log.Info(e.ToString());
            }
        }
    }
}
