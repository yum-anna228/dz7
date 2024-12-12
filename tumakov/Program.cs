using System.Drawing;
using System.Globalization;
using System.IO;
namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }

        //В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить
        //метод, который переводит деньги с одного счета на другой.У метода два параметра: ссылка
        //на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
        static void Task1()
        {
            Console.WriteLine("Упражнение 8.1");
            BankAccount account1 = new BankAccount("123456", 1000, AccountType.Текущий);
            BankAccount account2 = new BankAccount("654321", 500, AccountType.Сберегательный);
            account1.Info();
            account2.Info();
            account1.Transfer(account2, 200);
            account1.Info();
            account2.Info();
        }
        //Реализовать метод, который в качестве входного параметра принимает
        //строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.
        //Протестировать метод.
        static void Task2()
        {
            Console.WriteLine("Упражнение 8.2");
            string originalString = "Хочется выходной";
            string reversedString = ReverseString(originalString);

            Console.WriteLine($"Исходная строка: {originalString}");
            Console.WriteLine($"Строка в обратном порядке: {reversedString}");
        }
        /// <summary>
        /// Метод к номеру 8.2, который переворачивает строку
        /// </summary>
        static public string ReverseString(string stroka)
        {
            if (stroka == null)
            {
                throw new ArgumentNullException(nameof(stroka), "Входная строка не может быть пустой");
            }
            char[] chars = stroka.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        //Написать программу, которая спрашивает у пользователя имя файла. Если
        //такого файла не существует, то программа выдает пользователю сообщение и заканчивает
        //работу, иначе в выходной файл записывается содержимое исходного файла, но заглавными
        //буквами.
        static void Task3()
        {
            Console.WriteLine("Упражнение 8.3");
            Console.WriteLine("Введите имя файла");
            string path = $"../../../txt/{Console.ReadLine()}";
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                StreamReader r = new StreamReader(path);
                string s = r.ReadToEnd();
                // Console.WriteLine(s.ToUpper());
                r.Close();
                StreamWriter wr = new StreamWriter("../../../txt/res3.txt");
                wr.WriteLine(s.ToUpper());
                wr.Close();

            }
            else
            {
                Console.WriteLine("Файла не существует");
            }
        }
        /// <summary>
        /// Метод к упр 8.4, который проверяет реализует ли объект интерфейс IFormattable с помощью операторов is/as
        /// </summary>
        static bool CheckIfFormattable(object parametr)
        {
            if (parametr is IFormattable) //проверяем с помощью is
            {
                Console.WriteLine($"{parametr} реализует IFormattable");
                return true;
            }

            var formattable = parametr as IFormattable; //проверяем с помощью as
            if (formattable != null)
            {
                Console.WriteLine($"{parametr} реализует IFormattable");
                return true;
            }

            Console.WriteLine($"{parametr} не реализует IFormattable.");
            return false;
        }
        //Реализовать метод, который проверяет реализует ли входной параметр
        //метода интерфейс System.IFormattable.Использовать оператор is и as. (Интерфейс
        //IFormattable обеспечивает функциональные возможности форматирования значения объекта
        //в строковое представление.)
        static void Task4()
        {
            Console.WriteLine("Упражнение 8.4");
            object par1 = 456;
            object par2 = "Cake";
            object par3 = 56.3m;

            Console.WriteLine(CheckIfFormattable(par1));
            Console.WriteLine(CheckIfFormattable(par2));
            Console.WriteLine(CheckIfFormattable(par3));
        }
        /// <summary>
        /// Метод к домашнему заданию 8.1, который выделяет из строки адрес почты
        /// </summary>
        public static void SearchMail(ref string s)
        {
            var parts = s.Split('#');
            if (parts.Length > 1)
            {
                s = parts[1].Trim();
            }
            else
            {
                s = string.Empty;
            }
        }
        //Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail
        //адрес.Разделителем между ФИО и адресом электронной почты является символ #:
        //Иванов Иван Иванович # iviviv@mail.ru
        //Петров Петр Петрович # petr@mail.ru
        //Сформировать новый файл, содержащий список адресов электронной почты.
        //Предусмотреть метод, выделяющий из строки адрес почты.Методу в
        //качестве параметра передается символьная строка s, e-mail возвращается в той же строке s:
        //public void SearchMail(ref string s).
        static void Task5()
        {
            Console.WriteLine("Домашнее задание 8.1");
            string input = "../../../2.txt";
            string output = "../../../res2.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(output))
                {
                    foreach (var line in File.ReadLines(input))
                    {
                        string emailLine = line;
                        SearchMail(ref emailLine);
                        if (!string.IsNullOrEmpty(emailLine))
                        {
                            writer.WriteLine(emailLine);
                        }
                    }
                }

                Console.WriteLine("Список адресов электронной почты готов");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
        //Список песен. В методе Main создать список из четырех песен. В
        //цикле вывести информацию о каждой песне.Сравнить между собой первую и вторую
        //песню в списке. Песня представляет собой класс с методами для заполнения каждого из
        //полей, методом вывода данных о песне на печать, методом, который сравнивает между
        //собой два объекта:
        static void Task6()
        {
            Console.WriteLine("Домашнее задание 8.2");
            List<Song> songs = new List<Song>();
            for (int i = 0; i < 4; i++)
            {
                Song song = new Song();
                Console.WriteLine($"Введите название песни {i + 1}:");
                song.SongName(Console.ReadLine());
                Console.WriteLine($"Введите автора песни {i + 1}:");
                song.AuthorName(Console.ReadLine());

                if (i > 0)
                {
                    song.Prev(songs[i - 1]); 
                }

                songs.Add(song);
            }
            Console.WriteLine("\nСписок песен:");
            foreach (var song in songs)
            {
                song.Info();
            }

            if (songs.Count >= 2)
            {
                bool areEqual = songs[0].Equals(songs[1]);
                Console.WriteLine($"\nПервая и вторая песни {(areEqual ? "равны" : "не равны")}.");
            }
            else
            {
                Console.WriteLine("Недостаточно песен для сравнения.");
            }

        }
    }
}
