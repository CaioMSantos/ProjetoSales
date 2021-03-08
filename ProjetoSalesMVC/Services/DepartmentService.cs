using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoSalesMVC.Models;

namespace ProjetoSalesMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoSalesMVCContext _context;

        public DepartmentService(ProjetoSalesMVCContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
