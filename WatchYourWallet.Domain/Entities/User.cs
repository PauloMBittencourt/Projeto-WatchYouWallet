using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchYourWallet.Domain.Validations;

namespace WatchYourWallet.Domain.Entities
{
    public sealed class User
    {
        public int UserId { get; private set; }
        public string Name { get; private set; }
        public decimal? Salary { get; private set; }

        public User(int userId, string name, decimal salary)
        {

            UserId = userId;
            Name = name;
            Salary = salary;
        }

        public User(string name, decimal salary)
        {
            ValidateDomain(name, salary);

            Name = name;
            Salary = salary;
        }


        public ICollection<Expenses> Expense { get; set; }

        private void ValidateDomain(string name, decimal salary)
        {
            //Validação do Nome
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Nome inválido, o atributo é obrigatório");
            DomainExceptionValidation.When(name.Length < 3, "Nome inválido, minomo de 3 caracteres");
            Name = name;

            //Validação do Salário
            DomainExceptionValidation.When(decimal.IsNegative(salary), "O valor do salário é invalido.");
            DomainExceptionValidation.When(salary.Equals(null) , "O valor do salário é obrigatório.");
            Salary = salary;
        }
    }
}
