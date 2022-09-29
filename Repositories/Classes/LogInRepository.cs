using TownhomeQuestionnaire.API.JWT;
using TownhomeQuestionnaire.API.Model;
using Newtonsoft.Json;
using TownhomeQuestionnaire.API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownhomeQuestionnaire.API.Repositories.Class;

namespace Repository.Class
{
    public class LogInRepository : BaseRepository, ILogInRepository
    {
        public async Task<bool> LogInUser(LogIn logInUser)
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);

                var userList = JsonConvert.DeserializeObject<User>(jsonString);

                if (userList is not null 
                    && userList.Users.Any(x => x.Email.ToLower() == logInUser.UserName.ToLower()) 
                    && userList.Users.FirstOrDefault(x=>x.Email.ToLower() == logInUser.UserName.ToLower()).Password == logInUser.Password)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
