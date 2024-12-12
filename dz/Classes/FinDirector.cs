using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// класс-наследник, который представлякт финансового директора
    /// </summary>
    public class FinDirector : Employee
    {
        /// <summary>
        /// конструктор
        /// </summary>
        public FinDirector(string name, Employee supervisor) : base(name, supervisor) { }

        /// <summary>
        /// метод, который определяет может ли фин директор взять задачу
        /// </summary>
        public override bool Zadacha(string task)
        {
            return true; // Финансовый директор всегда принимает задачи
        }
    }
}
