using TownhomeQuestionnaire.API.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownhomeQuestionnaire.API.Model;

namespace Services.Interface
{
    public interface IUserService
    {
        Task<User> GetAllUsers();
        Task<Register> GetUserByEmail(string email);
        Task<bool> UpdateUserByEmail(string email, Register updatedUser);
    }
}
