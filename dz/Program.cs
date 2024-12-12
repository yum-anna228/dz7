namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, содержащую решение следующих задач:
            //На совещании у начальства раздавали задачи. Сотрудники фирмы так задолбались, что
            //решили, что будут получать задачи только в том случае, если это их прямое руководство.
            //Все возмущение началось из‐за того, что бухгалтерия решила автоматизировать себе работу,
            //они хотят приходить на работу, нажимать на кнопочку и чтобы все само делалось, а отдел
            //информационных технологий должен сделать эту задачу им. Перейдем к иерархии
            //сотрудников:
            //Главный в конторе Тимур – генеральный директор.
            //У Тимура есть подчиненные:
            //Финансовый директор – Рашид,
            //Директор по автоматизации – О Ильхам.
            //Рашид в подчинении держит бухгалтерию.В бухгалтерии главный Лукас.
            //О Ильхам в подчинении держит отдел информационных технологий. В отделе
            //информационных технологий следующая иерархия: существует начальник, зам.
            //начальника и 2 сектора.
            //Начальник инф систем – Оркадий
            //Зам.начальника – Володя.
            //○ системщики(занимаются сетями).Главный в секторе системщиков: Ильшат,
            //Зам: Иваныч, Сотрудники: Илья, Витя, Женя
            //○ разработчики(разработка и сопровождение).Главный секторе разработчиков:
            //Сергей, Зам: Ляйсан, Сотрудники: Марат, Дина , Ильдар, Антон.
            //Таким образом, Дина, Марат, Ильдар, Антон слушаются Ляйсан, Ляйсан слушается
            //только Сергея, Сергей может слушаться Оркадия и Володю. Аналогично и с
            //сектором системщиков.Организовать иерархию конторы, создать несколько
            //примитивых задач.
            //При назначении задач, задача должна иметь признак кому ее дают: системщикам или
            //разработчикам или начальству(начальник и зам.начальник отдела), а потом
            //распределить задачи по сотрудникам. На экране будет следующее: от человека А
            //даётся задача «название задачи» человек Б. И надо вывести берет человек задачу или нет.

            GenDirector timur = new GenDirector("Тимур");
            FinDirector rashid = new FinDirector("Рашид", timur);
            Accountant lukas = new Accountant("Лукас", rashid);

            ITDirector ilham = new ITDirector("Ильхам", timur);
            ITManager orkadiy = new ITManager("Оркадий", ilham);
            ITManager volodya = new ITManager("Володя", ilham);

            ITWorker ilshat = new ITWorker("Ильшат", orkadiy);
            ITWorker ivanych = new ITWorker("Иваныч", orkadiy);
            ITWorker ilya = new ITWorker("Илья", ilshat);
            ITWorker vitya = new ITWorker("Витя", ilshat);
            ITWorker zhenya = new ITWorker("Женя", ilshat);

            ITWorker sergey = new ITWorker("Сергей", orkadiy);
            ITWorker laysan = new ITWorker("Ляйсан", sergey);
            ITWorker marat = new ITWorker("Марат", laysan);
            ITWorker dina = new ITWorker("Дина", laysan);
            ITWorker ildar = new ITWorker("Ильдар", laysan);
            ITWorker anton = new ITWorker("Антон", laysan);

            Console.WriteLine("Выбор задачи:");
            Console.WriteLine("1 - Задача для финансового директора");
            Console.WriteLine("2 - Задача для бухгалтера");
            Console.WriteLine("3 - Задача для ИТ-работника");
            Console.WriteLine("4 - Задача для системщика");
            Console.WriteLine("5 - Задача для разработчика");
            Console.WriteLine("Введите номер задачи:");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Ошибка: введено некорректный номер задачи.");
                return;
            }
            string taskName = "Автоматизация работы"; // Пример задачи

            switch (choice)
            {
                case 1:
                    rashid.PrintZadacha(taskName, timur.Name);
                    if (rashid.Zadacha(taskName))
                    {
                        Console.WriteLine($"{rashid.Name} принял задачу.");
                    }
                    else
                    {
                        Console.WriteLine($"{rashid.Name} не принял задачу.");
                    }
                    break;

                case 2:
                    lukas.PrintZadacha(taskName, rashid.Name);
                    if (lukas.Zadacha(taskName))
                    {
                        Console.WriteLine($"{lukas.Name} принял задачу.");
                    }
                    else
                    {
                        Console.WriteLine($"{lukas.Name} не принял задачу.");
                    }
                    break;

                case 3:
                    volodya.PrintZadacha(taskName, ilham.Name);
                    if (volodya.Zadacha(taskName))
                    {
                        Console.WriteLine($"{volodya.Name} принял задачу.");
                    }
                    else
                    {
                        Console.WriteLine($"{volodya.Name} не принял задачу.");
                    }
                    break;

                case 4:
                    ilshat.PrintZadacha(taskName, volodya.Name);
                    if (ilshat.Zadacha(taskName))
                    {
                        Console.WriteLine($"{ilshat.Name} принял задачу.");
                    }
                    else
                    {
                        Console.WriteLine($"{ilshat.Name} не принял задачу.");
                    }
                    break;

                case 5:
                    sergey.PrintZadacha(taskName, orkadiy.Name);
                    if (sergey.Zadacha(taskName))
                    {
                        Console.WriteLine($"{sergey.Name} принял задачу.");
                    }
                    else
                    {
                        Console.WriteLine($"{sergey.Name} не принял задачу.");
                    }
                    break;

                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
    
}
