using WatchYourWallet.Domain.Entities;

namespace WatchYourWallet.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetById(int id);

        Task<User> CreateExpense(User Users);
        Task<User> UpdateExpense(User Users);
        Task<User> RemoveExpense(User Users);
    }
}
