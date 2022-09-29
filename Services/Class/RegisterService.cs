using TownhomeQuestionnaire.API.JWT;
using Services.Interface;
using TownhomeQuestionnaire.API.Model;

namespace Services.Class
{
    public class RegisterService : BaseService, IRegisterService
    {
        public async Task<bool> RegisterUser(Register registerUser)
        {
            try
            {
                registerUser.Password = Encrypt(Encrypt(registerUser.Password));
                var result = await RepositoryFactory.RegisterRepository.RegisterUser(registerUser);
                if (result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
