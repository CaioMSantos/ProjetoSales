using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoSalesMVC.Models;

namespace ProjetoSalesMVC.Data
{
    public class ProjetoSalesMVCContext : DbContext
    {
        public ProjetoSalesMVCContext (DbContextOptions<ProjetoSalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoSalesMVC.Models.Department> Department { get; set; }
    }
}
