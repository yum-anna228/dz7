using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// класс-наследник, который представляет директора по автоматизации
    /// </summary>
    public class ITDirector : Employee
    {
        /// <summary>
        /// конструктор
        /// </summary>
        public ITDirector(string name, Employee supervisor) : base(name, supervisor) { }

        /// <summary>
        /// метод, который определяет может ли директор взять задачу
        /// </summary>
        public override bool Zadacha(string task)
        {
            return true; // Директор по автоматизации всегда принимает задачи
        }
    }
}
