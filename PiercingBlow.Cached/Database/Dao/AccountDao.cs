using Dapper;
using PiercingBlow.Cached.Config;
using PiercingBlow.Commons.Interface.WCF.Cached;
using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Model.Enum.Login;
using PiercingBlow.Commons.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace PiercingBlow.Cached.Database.Dao
{
    public class AccountDao : IAccountDao
    {
        private static readonly Logger Log = Logger.Instance;

        private DatabaseFactory Factory = DatabaseFactory.Instance;

        static readonly Dictionary<int, Account> Accounts = new Dictionary<int, Account>();

        public static void Initialize()
        {
            Uri uri = new Uri("http://" + CachedConfig.IPAddress + ":" + CachedConfig.Port + "/IAccountDao");
            ServiceHost host = new ServiceHost(typeof(AccountDao), uri);
            host.AddServiceEndpoint(typeof(IAccountDao), new BasicHttpBinding(), "");
            host.Open();
            Log.Info("WCF Service [{0}] successfully loaded", uri.OriginalString);
        }

        public LoginState IsValidAccount(string login, string password)
        {
            using (var connection = Factory.conn)
            {
                string sql = @"SELECT `accounts`.* FROM `accounts` WHERE `Login` = @Login LIMIT 1";
                var account = SqlMapper.Query<Account>(connection, sql, new { Login = login }).FirstOrDefault();

                if (account.Password == password)
                {
                    if (Accounts.ContainsKey(account.Id))
                    {
                        return LoginState.ID_IS_ALREADY_LOGGED_IN;
                    }
                    else
                    {
                        Accounts.Add(account.Id, account);
                        return LoginState.LOGGED_IN_OK;
                    }
                }
                else
                {
                    return LoginState.ID_OR_PASSWORD_INCORRECT;
                }
            }
        }

        public Account GetAccount(string login)
        {
            using (var connection = Factory.conn)
            {
                string sql = @"SELECT `accounts`.* FROM `accounts` WHERE `Login` IN(@Login) LIMIT 1";
                var account = SqlMapper.Query<Account>(connection, sql, new { Login = login }).FirstOrDefault();
                return account;
            }
        }

        public void RemoveAccount(int id)
        {
            Accounts.Remove(id);
        }
    }
}
