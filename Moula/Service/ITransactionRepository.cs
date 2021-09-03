using Moula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moula.Repository.Interface
{
    public interface ITransactionRepository
    {
        IEnumerable<Transactions> GetTransactionsByAccountID(int accountID);
    }
}
