using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moula.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
