using TownhomeQuestionnaire.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownhomeQuestionnaire.API.Repositories.Interface
{
    public interface ILogInRepository
    {
        Task<bool> LogInUser(LogIn logInUser);
    }
}
