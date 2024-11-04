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

        // این متد یک ریپوزیتوری جنریک از نوع داده‌ی مشخص شده برمی‌گرداند
        IGenericRepository<T> Repository<T>() where T : class;

        // متدی برای ذخیره‌سازی تغییرات در دیتابیس

        Task<int> SaveAsync();

    }

}
