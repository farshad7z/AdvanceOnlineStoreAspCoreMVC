using OnlineStore.BLL.Interfaces;
using OnlineStore.Core.Interfaces;
using OnlineStore.DAL.Entities.Models;
using OnlineStore.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddUser(User user)
        {
            await _unitOfWork.Repository<User>().AddAsync(user);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteUser(int id)
        {
            await _unitOfWork.Repository<User>().DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsers() => await _unitOfWork.Repository<User>().GetAllAsync();

        public async Task<User> GetUserByID(int id) => await _unitOfWork.Repository<User>().GetByIdAsync(id);
        public async Task<IEnumerable<User>> SearchUsersByDetails(string filter)
            => await _unitOfWork.Repository<User>().FindAsync(p => p.UserName == filter);


        public async Task UpdateUser(User user)
        {
            await _unitOfWork.Repository<User>().UpdateAsync(user);
            await _unitOfWork.SaveAsync();
        }
    }
}
