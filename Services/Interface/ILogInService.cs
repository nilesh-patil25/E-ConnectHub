using TownhomeQuestionnaire.API.JWT;
using TownhomeQuestionnaire.API.Model;

namespace Services.Interface
{
    public interface ILogInService
    {
        Task<bool> LogInUser(LogIn logInUser);
    }
}
