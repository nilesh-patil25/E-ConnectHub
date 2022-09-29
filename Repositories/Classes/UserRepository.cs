using TownhomeQuestionnaire.API.JWT;
using Newtonsoft.Json;
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
    public class UserRepository : BaseRepository, IUserRepository
    {
        public async Task<User> GetAllUsers()
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);

                var userList = new User();

                userList = JsonConvert.DeserializeObject<User>(jsonString);

                if (userList is not null)
                { 
                    return userList; 
                }
                else
                {
                    throw new NullReferenceException();
                }

                
            }
            catch (Exception ex)
            {
                return new User();
            }
        }

        public async Task<Register> GetUserByEmail(string email)
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);

                var userList = new User();

                userList = JsonConvert.DeserializeObject<User>(jsonString);

                if (userList is not null)
                {
                    var user = userList.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
                    if (user is not null)
                    {
                        return user;
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
                else
                {
                    throw new NullReferenceException();
                }


            }
            catch (Exception ex)
            {
                return new Register();
            }
        }

        public async Task<bool> UpdateUserByEmail(string email, Register updateduser)
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);

                var userList = new User();

                userList = JsonConvert.DeserializeObject<User>(jsonString);

                if (userList is not null)
                {
                    var user = userList.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
                    if (user is not null)
                    {
                        user = updateduser;
                        var newUserList = JsonConvert.SerializeObject(userList);
                        File.WriteAllText(jsonFile, newUserList);
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
