using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchYourWallet.Domain.Entities;
using WatchYourWallet.Infra.Context;

namespace WatchYourWallet.Infra.Repositories.Concrete
{
    public class UserRepository
    {
        private readonly ConnectionContextFb _conn;

        public List<User> GetUsers()
        {


            return null;
        }

        public Task<User> SetUser(User user)
        {
            try
            {
                var userNew = new User(user.Name, user.Salary); 

                var SetData = _conn.client.Set("people/" +  user.Name, userNew);

                return Task.FromResult(userNew);
            } catch (Exception e)
            {
                    throw new Exception(e.Message);
            }

        }
    }
}
