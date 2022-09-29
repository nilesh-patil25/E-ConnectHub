using TownhomeQuestionnaire.API.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownhomeQuestionnaire.API.Model;

namespace Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> GetAllUsers();
        Task<Register> GetUserByEmail(string email);
        Task<bool> UpdateUserByEmail(string email, Register updateduser);

    }
}
