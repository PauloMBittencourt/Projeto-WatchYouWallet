using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchYourWallet.Domain.Entities;
using WatchYourWallet.Domain.Interfaces;
using WatchYourWallet.Infra.Data.Context;

namespace WatchYourWallet.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        
        ApplicationDbContext _applicationDbContext;
        public UserRepository(ApplicationDbContext context)
        {
            _applicationDbContext = context;
        }

        public async Task<User> CreateExpense(User Users)
        {
            _applicationDbContext.Add(Users);
            await _applicationDbContext.SaveChangesAsync();
            return Users;
        }

        public async Task<User> GetById(int id)
        {
            return await _applicationDbContext.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _applicationDbContext.Users.ToListAsync();
        }

        public async Task<User> RemoveExpense(User Users)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateExpense(User Users)
        {
            throw new NotImplementedException();
        }
    }
}
