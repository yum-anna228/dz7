using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// класс-наследник, который представляет зам. начальника
    /// </summary>
    public class ITManager : Employee
    {
        /// <summary>
        /// конструктор
        /// </summary>
        public ITManager(string name, Employee supervisor) : base(name, supervisor) { }
        /// <summary>
        /// метод, который определяет может ли зам начальника взять задачу
        /// </summary>
        public override bool Zadacha(string task)
        {
            return Supervisor is ITDirector; // Принимает задачу только от директора по автоматизации
        }
    }
}
