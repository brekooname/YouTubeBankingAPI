using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouTubeNetcoreBankAPI.Models;

namespace YouTubeNetcoreBankAPI.Services.Interfaces
{
    public interface ITransactionService
    {
        Response CreateNewTransaction(Transaction transaction); // we will create a Response model just wait
        Response FindTransactionByDate(DateTime date);
        Response MakeDeposit(string AccountNumber, decimal Amount, string TransactionPin);
        Response MakeWithdrawal(string AccountNumber, decimal Amount, string TransactionPin);
        Response MakeFundsTransfer(string FromAccount, string ToAccount, decimal Amount, string TransactionPin);


    }
}
