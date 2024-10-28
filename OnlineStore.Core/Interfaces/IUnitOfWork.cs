using OnlineStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Rolse> RolseRepository { get; }
        IGenericRepository<User> UserRepository { get; }

        IGenericRepository<Product> ProductRepository { get; }

        Task<int> SaveAsync();

    }
}
