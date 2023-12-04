using WatchYourWallet.Domain.Entities.Base;
using WatchYourWallet.Domain.Validations;

namespace WatchYourWallet.Domain.Entities
{
    public sealed class User : EntityBase
    {
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public User(string name, decimal salary)
        {
            ValidateDomain(name, salary);
        }

        public User(int userId, string name, decimal salary)
        {
            //Validação do ID
            DomainExceptionValidation.When(userId < 0, "O ID é inválido, precisa ser maior que 0.");
            Id = userId;

            ValidateDomain(name, salary);
        }

        public void Update(User user)
        {
            ValidateDomain(user.Name, user.Salary);
        }

        public ICollection<Expense> Expense { get; set; }

        #region Validações
        private void ValidateDomain(string name, decimal salary)
        {
            //Validação do Nome
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Nome inválido, o atributo é obrigatório");
            DomainExceptionValidation.When(name.Length < 3, "Nome inválido, minomo de 3 caracteres");
            Name = name;

            //Validação do Salário
            DomainExceptionValidation.When(decimal.IsNegative(salary), "O valor do salário é invalido.");
            DomainExceptionValidation.When(salary.Equals(null), "O valor do salário é obrigatório.");
            Salary = salary;
        } 
        #endregion
    }
}
