using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// Класс-наследник, представляет бухгалтера
    /// </summary>
    public class Accountant : Employee
    {
        /// <summary>
        /// конструктор
        /// </summary>
        public Accountant(string name, Employee supervisor) : base(name, supervisor) { }

        /// <summary>
        /// метод, который определяет может ли бухгалтер взять задачу
        /// </summary>
        public override bool Zadacha(string task)
        {
            return Supervisor is FinDirector; // Принимает задачи от финансового директора
        }
    }
}
