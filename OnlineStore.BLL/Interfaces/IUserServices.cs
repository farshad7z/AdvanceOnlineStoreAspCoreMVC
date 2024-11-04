using OnlineStore.Core.Interfaces;
using OnlineStore.DAL.Models;
using OnlineStore.DAL.Repositoreis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Interfaces
{
    public interface IUserServices
    {
        Task<User> GetUserByID(int id);
        Task<IEnumerable<User>> GetAllUsers();

        Task<IEnumerable<User>> SearchUsersByDetails(string filter);

        Task AddUser(User user);

        Task DeleteUser(int id);
        Task UpdateUser(User user);

       
    }
}
