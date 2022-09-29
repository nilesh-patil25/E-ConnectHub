using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownhomeQuestionnaire.API.Repositories.Interface;

namespace Repository
{
    public interface IRepositoryFactory
    {
        ILogInRepository LogInRepository { get; }
        IRegisterRepository RegisterRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
