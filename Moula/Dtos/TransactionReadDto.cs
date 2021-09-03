using Moula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moula.Dtos
{
    public class TransactionReadDto
    {
        public decimal AccountBalance { get; set; }
        public List<Transactions> Transactions { get; set; }
    }
}
