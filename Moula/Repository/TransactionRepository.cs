using Moula.Data;
using Moula.Models;
using Moula.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moula.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MoulaContext _context;
        public TransactionRepository(MoulaContext context)
        {
            _context = context;
        }
        public IEnumerable<Transactions> GetTransactionsByAccountID(int accountID)
        {
            return _context.Transactions.Where(m=>m.AccountID == accountID);
        }
    }
}
