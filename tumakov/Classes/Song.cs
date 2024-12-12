using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    /// <summary>
    /// Класс, который представляет песню
    /// </summary>
    public class Song
    {
        private string name;
        private string author;
        private Song prev;

        /// <summary>
        /// Метод, который устанавливает название песни
        /// </summary>
        public void SongName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Метод, который устанавливает автора песни
        /// </summary>
        public void AuthorName(string author)
        {
            this.author = author;
        }
        /// <summary>
        /// Метод, который устанавливает ссылку на предыдущую
        /// </summary>
        /// <param name="prev"></param>
        public void Prev(Song prev)
        {
            this.prev = prev;
        }
        /// <summary>
        /// Метод для вывода названия песни и автора
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"{Title}");
        }
        /// <summary>
        /// Метод, который возвращает название песни и автора
        /// </summary>
        public string Title()
        {
            return $"{name} - {author}";
        }
        /// <summary>
        /// Метод, который сравнивает между собой два объекта-песни
        /// </summary>
        public override bool Equals(object d)
        {
            if (d is Song otherSong)
            {
                return name == otherSong.name && author == otherSong.author;
            }
            return false;
        }
    }
}
