using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchYourWallet.Domain.Entities.Base;
using WatchYourWallet.Domain.Validations;

namespace WatchYourWallet.Domain.Entities
{
    public sealed class Expenses : EntityBase
    {
        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public DateTime InitialDate { get; private set; }
        public DateTime LastDate { get; private set; }

        public Expenses(string name, decimal value, DateTime initialDate, DateTime lastDate)
        {
            ValidateDomain(name, value, initialDate, lastDate);
        }
        
        public Expenses(int expensesId, string name, decimal value, DateTime initialDate, DateTime lastDate)
        {
            //Validação do ID
            DomainExceptionValidation.When(expensesId < 0, "O ID é inválido, precisa ser maior que 0.");
            Id = expensesId;

            ValidateDomain(name, value, initialDate, lastDate);
        }

        public void Update(string name, decimal value, DateTime initialDate, DateTime lastDate, int usersId)
        {
            ValidateDomain(name, value, initialDate, lastDate);
            UserId = usersId;
        }

        private void ValidateDomain(string name, decimal value, DateTime initiaDate, DateTime lastDate)
        {
            //Validação do Nome
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Nome inválido, o atributo é obrigatório");
            DomainExceptionValidation.When(name.Length < 3, "Nome inválido, minomo de 3 caracteres");
            Name = name;

            //Validação do Valor
            DomainExceptionValidation.When(decimal.IsNegative(value), "O valor é invalido.");
            DomainExceptionValidation.When(value.Equals(null), "O valor é obrigatório.");
            Value = value;

            //Validação da data inicial
            DomainExceptionValidation.When(initiaDate.Equals(null), "A data inicial da compra é obrigatória.");
            InitialDate = initiaDate;

            //Validação da data final
            DomainExceptionValidation.When(lastDate.Equals(null), "A data final da compra é obrigatória.");
            LastDate = lastDate;
        }

        public int UserId { get; private set; }
        public User Users { get; private set; }


    }
}
