using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moula.Dtos;
using Moula.Repository.Interface;

namespace Moula.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionRepository _repository;


        public TransactionsController(ITransactionRepository repository)
        {
            _repository = repository;

        }

        [HttpGet("{accountID}")]
        public ActionResult<TransactionReadDto> GetTransactionsByAccountID(int accountID)
        {
            TransactionReadDto transaction = new TransactionReadDto();
        
            var transactions = _repository.GetTransactionsByAccountID(accountID).OrderByDescending(m => m.Date.Date).ThenByDescending(m=>m.Date.TimeOfDay).ToList();

            if (transactions.Any())
            {
                transaction.Transactions = transactions;

                transaction.AccountBalance = transactions.Sum(m => m.Amount);

                return Ok(transaction);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
