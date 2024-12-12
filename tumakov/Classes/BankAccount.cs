using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    /// <summary>
    /// Перечисление типов счёта
    /// </summary>
    public enum AccountType
    {
        Текущий,
        Сберегательный
    }
    class BankAccount
    {
        private string number;
        private decimal balans;
        private AccountType accountType;

        /// <summary>
        /// конструктор
        /// </summary>
        public BankAccount(string number, decimal initialBalans, AccountType accountType)
        {
            this.number = number;
            this.balans = initialBalans;
            this.accountType = accountType;
        }
        /// <summary>
        /// Метод пополнения счёта
        public void Popolnenie(decimal symma)
        {
            if (symma > 0)
            {
                balans += symma;
                Console.WriteLine($"Произошло пополнение на {symma}. Новый баланс {balans}");
            }
            else
            {
                Console.WriteLine("Сумма не может быть отрицательной!");
            }
        }
        /// <summary>
        /// Метод вывода со счёта
        /// </summary>
        public void Withdraw(decimal symma)
        {
            if (symma <= 0)
            {
                Console.WriteLine("Сумма вывода должна быть положительной");
                return;
            }
            if (symma > balans)
            {
                Console.WriteLine("У вас недостаточно средств");
            }
            else
            {
                balans -= symma;
                Console.WriteLine($"Произошел вывод средств на {symma}. Новый баланс {balans}");
            }
        }
        /// <summary>
        /// Метод, который отправляет сумму с одного счёта на другой
        /// </summary>
        public void Transfer(BankAccount targetAccount, decimal symma)
        {
            if (targetAccount == null)
            {
                throw new ArgumentNullException(nameof(targetAccount), "Целевой счет не может быть null.");
            }
            if (symma <= 0)
            {
                throw new ArgumentException("Сумма перевода должна быть положительной.");
            }
            Withdraw(symma); // Снять деньги с текущего счета
            targetAccount.Popolnenie(symma); // Перевести деньги на целевой счет
        }
        /// <summary>
        /// Метод, который выводит информацию
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balans}");
            Console.WriteLine($"Тип счета: {accountType}");
        }
    }
}
