using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// класс-наследник, который представляет сотрудников в двух секторах
    /// </summary>
    public class ITWorker : Employee
    {
        /// <summary>
        /// конструктор
        /// </summary>
        public ITWorker(string name, Employee supervisor) : base(name, supervisor) { }

        /// <summary>
        /// метод, который определяет могут ли сотрудники взять задачу
        /// </summary>
        public override bool Zadacha(string task)
        {
            return Supervisor is ITManager; 
        }
    }
}
