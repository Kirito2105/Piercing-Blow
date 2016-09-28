using System.ServiceModel;
using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Model.Enum.Login;

namespace PiercingBlow.Commons.Interface.WCF.Cached
{
    [ServiceContract]
    public interface IAccountDao
    {
        [OperationContract]
        LoginState IsValidAccount(string login, string password);
        [OperationContract]
        Account GetAccount(string login);
        [OperationContract]
        void RemoveAccount(int id);
    }
}
