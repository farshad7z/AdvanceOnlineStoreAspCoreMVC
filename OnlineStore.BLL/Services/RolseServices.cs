using OnlineStore.BLL.Interfaces;
using OnlineStore.Core.Interfaces;
using OnlineStore.Core.Entities.Models;
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

        public RolseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddRolseAsync(Rolse rolse)
        {
            await _unitOfWork.Repository<Rolse>().AddAsync(rolse);
            await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteRolseAsync(int id)
        {
            var rosle = GetByRolseIdAsync(id);
            if (rosle != null)
            {
              await  _unitOfWork.Repository<Rolse>().DeleteAsync(id);
              await _unitOfWork.SaveAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Rolse>> GetAllRolseAsync()=> await _unitOfWork.Repository<Rolse>().GetAllAsync();

        public async Task<Rolse?> GetByRolseIdAsync(int id)
        {
          return await _unitOfWork.Repository<Rolse>().GetByIdAsync(id);
        }

        public async Task UpdateRolseAsync(Rolse rolse)
        {
       
              await  _unitOfWork.Repository<Rolse>().UpdateAsync(rolse);
            await _unitOfWork.SaveAsync();
            
        }
    }
}
