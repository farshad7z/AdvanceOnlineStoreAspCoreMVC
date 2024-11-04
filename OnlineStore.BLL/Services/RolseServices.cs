using OnlineStore.BLL.Interfaces;
using OnlineStore.Core.Interfaces;
using OnlineStore.DAL.Models;
using OnlineStore.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Services
{
    public class RolseServices : IRolseServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public RolseServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddRolse(Rolse rolse)
        {
            await _unitOfWork.Repository<Rolse>().AddAsync(rolse);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<Rolse>> GetAllRolse()=> await _unitOfWork.Repository<Rolse>().GetAllAsync();  

    }
}
