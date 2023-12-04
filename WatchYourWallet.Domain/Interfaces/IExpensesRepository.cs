using WatchYourWallet.Domain.Entities;

namespace WatchYourWallet.Domain.Interfaces
{
    public interface IExpensesRepository
    {
        Task<IEnumerable<Expenses>> GetExpenses();
        Task<Expenses> GetById(int id);
        Task<Expenses> CreateExpense(Expenses expenses);
        Task<Expenses> UpdateExpense(Expenses expenses);
        Task<Expenses> RemoveExpense(Expenses expenses);

        Task<Expenses> GetUsersExpensesAsync(int id);

    }
}
