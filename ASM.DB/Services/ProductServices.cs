using ASM.DB.EF;
using ASM.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ASM.MVC.Services
{
    public class ProductServices
    {
        DbContext_Shop _dbContext;
        List<Product> _listProduct;

        public ProductServices()
        {
            _dbContext = new DbContext_Shop();
            _listProduct = new List<Product>();
        }

        private async Task GetListAsync()
        {
            _listProduct = await _dbContext.Products.ToListAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            await GetListAsync();
            return _listProduct;
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            await GetListAsync();
            return _listProduct.FirstOrDefault(c => c.Id == id);
        }

        public async Task<bool> CreateAsync(Product obj)
        {
            await _dbContext.Products.AddAsync(obj);
            await SaveChangesAsync();
            return _listProduct.Exists(c => c.Id == obj.Id);
        }

        public async Task<bool> UpdateAsync(Product obj)
        {
            await GetListAsync();
            var temp = _listProduct.FirstOrDefault(c => c.Id == obj.Id);
            if (temp != null)
            {
                await Task.FromResult(_dbContext.Products.Update(temp));
                await SaveChangesAsync();
                return true;
            }
            else return false;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            await GetListAsync();
            var temp = _listProduct.FirstOrDefault(c => c.Id == id);
            if (temp != null)
            {
                await Task.FromResult(_dbContext.Products.Remove(temp));
                await SaveChangesAsync();
                return true;
            }
            else return false;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
