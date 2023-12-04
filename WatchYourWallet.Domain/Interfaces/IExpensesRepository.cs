using WatchYourWallet.Domain.Entities;

namespace WatchYourWallet.Domain.Interfaces
{
    public interface IExpensesRepository
    {
        Task<IEnumerable<Expense>> GetExpenses();
        Task<Expense> GetById(int id);
        Task<Expense> CreateExpense(Expense expenses);
        Task<Expense> UpdateExpense(Expense expenses);
        Task<Expense> RemoveExpense(Expense expenses);

        Task<Expense> GetUsersExpensesAsync(int id);

    }
}
