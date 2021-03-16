using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoSalesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoSalesMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoSalesMVCContext _context;

        public DepartmentService(ProjetoSalesMVCContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
