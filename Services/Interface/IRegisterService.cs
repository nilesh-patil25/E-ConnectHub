using TownhomeQuestionnaire.API.JWT;
using TownhomeQuestionnaire.API.Model;

namespace Services.Interface
{
    public interface IRegisterService
    {
        Task<bool> RegisterUser(Register registerUser);
    }
}
