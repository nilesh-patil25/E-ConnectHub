using TownhomeQuestionnaire.API.JWT;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownhomeQuestionnaire.API.Model;
using TownhomeQuestionnaire.API.Repositories.Class;

namespace Repository.Class
{
    public class RegisterRepository : BaseRepository, IRegisterRepository
    {
        public async Task<bool> RegisterUser(Register registerUser)
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);
                
                var userList = JsonConvert.DeserializeObject<User>(jsonString);
                
                if (userList is not null && !userList.Users.Any(x=>x.Email.ToLower() == registerUser.Email.ToLower()))
                {
                    userList.Users.Add(registerUser);
                    var newUserList = JsonConvert.SerializeObject(userList);
                    File.WriteAllText(jsonFile, newUserList);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
