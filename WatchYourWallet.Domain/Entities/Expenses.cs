using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchYourWallet.Domain.Entities
{
    public sealed class Expense
    {
        public int ExpensesId { get; private set; }
        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public DateTime InitialDate { get; private set; }
        public DateTime LastDate { get; private set; }
        public int UserId { get; private set; }
        public User Users { get; private set; }


    }
}
