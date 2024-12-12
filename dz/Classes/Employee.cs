using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    /// <summary>
    /// Класс работника
    /// </summary>
    public abstract class Employee
    {
        public string Name { get; set; }
        public Employee Supervisor { get; set; }
        /// <summary>
        /// конструктор
        /// </summary>
        public Employee(string name, Employee supervisor)
        {
            Name = name;
            Supervisor = supervisor;
        }
        /// <summary>
        /// метод с задачей
        /// </summary>
        public abstract bool Zadacha(string task);

        public void PrintZadacha(string task, string from)
        {
            Console.WriteLine($"От {from} даётся задача \"{task}\" человеку {Name}.");
        }
    }
}