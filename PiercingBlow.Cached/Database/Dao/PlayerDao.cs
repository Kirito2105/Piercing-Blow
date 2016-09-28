using Dapper;
using PiercingBlow.Cached.Config;
using PiercingBlow.Commons.Interface.WCF.Cached;
using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Model.Enum.Player.Inventory;
using PiercingBlow.Commons.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace PiercingBlow.Cached.Database.Dao
{
    public class PlayerDao : IPlayerDao
    {
        private static readonly Logger Log = Logger.Instance;

        private DatabaseFactory Factory = DatabaseFactory.Instance;

        public static void Initialize()
        {
            Uri uri = new Uri("http://" + CachedConfig.IPAddress + ":" + CachedConfig.Port + "/IPlayerDao");
            ServiceHost host = new ServiceHost(typeof(PlayerDao), uri);
            host.AddServiceEndpoint(typeof(IPlayerDao), new BasicHttpBinding(), "");
            host.Open();
            Log.Info("WCF Service [{0}] successfully loaded", uri.OriginalString);
        }

        public Player GetPlayer(int accountId)
        {
            try
            {
                using (var connection = Factory.conn)
                {
                    string sql = @"SELECT `players`.* FROM `players` WHERE `AccountId` = @AccountId LIMIT 1";
                    var account = SqlMapper.Query<Player>(connection, sql, new { AccountId = accountId }).FirstOrDefault();
                    return account;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
            return null;
        }

        public List<Item> GetItems(int playerId)
        {
            try
            {
                using (var connection = Factory.conn)
                {
                    string sql = @"SELECT `items`.* FROM `items` WHERE `PlayerId` IN(@AccountId)";

                    var items = SqlMapper.Query<Item>(connection, sql, new { PlayerId = playerId }).ToList();

                    return items;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
            return null;
        }
    }
}
