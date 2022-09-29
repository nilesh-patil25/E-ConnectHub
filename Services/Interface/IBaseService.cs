using Repository;

namespace Services.Interface
{
    public interface IBaseService
    {
        IRepositoryFactory RepositoryFactory { get; }

        string Encrypt(string plainText);
    }
}
