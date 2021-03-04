using ProjetoSalesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalesMVC.Services
{
    public class SellerService
    {
        private readonly ProjetoSalesMVCContext _context;

        public SellerService(ProjetoSalesMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
