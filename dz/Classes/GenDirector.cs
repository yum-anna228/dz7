using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// класс-наследник, который представляет генерального директора
    /// </summary>
    public class GenDirector : Employee
    {
        /// <summary>
        /// конструктор
        /// </summary>
        public GenDirector(string name) : base(name, null) { }

        /// <summary>
        /// метод, который определяет может ли ген директор взять задачу
        /// </summary>
        public override bool Zadacha(string task)
        {
            return true; // Гендиректор всегда принимает задачи
        }
    }
}
