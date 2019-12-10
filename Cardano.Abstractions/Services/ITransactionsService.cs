using System.Collections.Generic;
using System.Threading.Tasks;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Models.Contexts;
using Cardano.Entities;
using Cardano.Entities.Transactions;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Transactions service
    /// </summary>
    public interface ITransactionsService
    {
        /// <summary>
        /// Returns the transaction history, i.e the list of all the past transactions.
        /// </summary>
        /// <param name="context">Query Parameters</param>
        /// <returns></returns>
        Task<Response<List<Transaction>>> RetrievesHistory(TransactionsContext context);
        
        /// <summary>
        /// Generates a new transaction from the source to one or multiple target addresses.
        /// </summary>
        /// <returns></returns>
        Task<Response<Transaction>> GeneratesTransaction(TransactionsRequest body);
        
        /// <summary>
        /// Redeem a certificate
        /// </summary>
        /// <returns></returns>
        Task<Response<Transaction>> RedeemCertificate(RedeemRequest body);

        /// <summary>
        /// Estimate the fees which would originate from the payment.
        /// </summary>
        /// <remarks>
        /// Estimate the fees which would incur from the input payment. This endpoint does not require
        /// a spending password to be supplied as it generates under the hood an unsigned transaction.
        /// </remarks>
        /// <returns></returns>
        Task<Response<long>> Estimate(TransactionsRequest body);
    }
}