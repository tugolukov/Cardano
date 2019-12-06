using System.Threading.Tasks;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Transactions service
    /// </summary>
    public interface ITransactionsService
    {
        Task RetrievesHistory();
        Task GeneratesTransaction();
        Task RedeemCertificate();
        Task Estimate();
    }
}