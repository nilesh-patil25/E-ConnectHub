using TownhomeQuestionnaire.API.JWT;
using Services.Interface;
using TownhomeQuestionnaire.API.Model;

namespace Services.Class
{
    public class LogInService : BaseService, ILogInService 
    {
        public async Task<bool> LogInUser(LogIn logInUser)
        {
            try
            {
                logInUser.Password = Encrypt(Encrypt(logInUser.Password));
                await RepositoryFactory.LogInRepository.LogInUser(logInUser);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
