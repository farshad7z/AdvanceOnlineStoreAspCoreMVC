using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Core.Data;
using OnlineStore.Core.Interfaces;
using OnlineStore.DAL.Models;
using OnlineStore.DAL.Repositoreis;


namespace OnlineStore.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EShopDbContext _context;
        private IGenericRepository<Rolse> _rolseRepository;
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Product> _productRepository;

        public UnitOfWork(EShopDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Rolse> RolseRepository => _rolseRepository ??= new GenericRepository<Rolse>(_context);

        public IGenericRepository<User> UserRepository => _userRepository ??= new GenericRepository<User>(_context);  

        public IGenericRepository<Product> ProductRepository => _productRepository ??= new GenericRepository<Product>(_context);

  
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
