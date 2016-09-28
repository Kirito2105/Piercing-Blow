using Dapper;
using PiercingBlow.Cached.Config;
using PiercingBlow.Commons.Interface.WCF.Cached;
using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Utils;
using System;
using System.Linq;
using System.ServiceModel;

namespace PiercingBlow.Cached.Database.Dao
{
    public class CharacterDao : ICharacterDao
    {
        private static readonly Logger Log = Logger.Instance;

        private DatabaseFactory Factory = DatabaseFactory.Instance;

        public static void Initialize()
        {
            Uri uri = new Uri("http://" + CachedConfig.IPAddress + ":" + CachedConfig.Port + "/ICharacterDao");
            ServiceHost host = new ServiceHost(typeof(CharacterDao), uri);
            host.AddServiceEndpoint(typeof(ICharacterDao), new BasicHttpBinding(), "");
            host.Open();
            Log.Info("WCF Service [{0}] successfully loaded", uri.OriginalString);
        }

        public Character GetCharacter(int accountId)
        {
            try
            {
                using (var connection = Factory.conn)
                {
                    string sql = @"SELECT `character`.* FROM `character` WHERE `AccountId` = @AccountId LIMIT 1";
                    var account = SqlMapper.Query<Character>(connection, sql, new { AccountId = accountId }).FirstOrDefault();
                    return account;
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
