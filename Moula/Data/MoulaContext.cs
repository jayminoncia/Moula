using Microsoft.EntityFrameworkCore;
using Moula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moula.Data
{
    public class MoulaContext : DbContext
    {
        public MoulaContext(DbContextOptions<MoulaContext> opt) : base(opt)
        {

        }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
