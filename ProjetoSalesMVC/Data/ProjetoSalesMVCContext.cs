﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoSalesMVC.Models;

namespace ProjetoSalesMVC.Models
{
    public class ProjetoSalesMVCContext : DbContext
    {
        public ProjetoSalesMVCContext (DbContextOptions<ProjetoSalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
