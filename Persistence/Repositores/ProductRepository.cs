using APIProject.Domain.Models;
using APIProject.Persistence.Context;
using APIProject.Persistence.Repositores.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APIProject.Persistence.Repositores
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        private readonly DataAppDbContext _context;
        public ProductRepository(DataAppDbContext context) : base(context)
        {
            _context = context;
        }

        private async Task Show(){
            var products = await _context.Products.FirstOrDefaultAsync<Product>(e => e.ProductId == 2);
        }
    }
}