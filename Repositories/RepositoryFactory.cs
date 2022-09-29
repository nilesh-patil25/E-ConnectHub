using Repository.Class;
using Repository.Interface;
using TownhomeQuestionnaire.API.Repositories.Interface;

namespace Repository
{
    public sealed class RepositoryFactory : IRepositoryFactory
    {
        public ILogInRepository LogInRepository { get; }

        public IRegisterRepository RegisterRepository { get; }
        public IUserRepository UserRepository { get; }

        public RepositoryFactory()
        {
            LogInRepository = new LogInRepository();

            RegisterRepository = new RegisterRepository();
            
            UserRepository = new UserRepository();

        }
    }
}