using PiercingBlow.Commons.Model.Enum.Player;
using System.ServiceModel;

namespace PiercingBlow.Commons.Interface.WCF.Cached
{
    [ServiceContract]
    public interface IPlayerDao
    {
        [OperationContract]
        Player GetPlayer(int accountId);
    }
}
