using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchYourWallet.Domain.Entities.Base
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
    }
}
