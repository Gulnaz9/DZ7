using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    internal class Song
    {
        string name; //название песни
        string author; //автор песни
        Song prev; //связь с предыдущей песней в списке
        /// <summary>
        ///метод для заполнения поля name
        /// </summary>
        /// <param name="name"></param>
        public void GetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///метод для заполнения поля author
        /// </summary>
        /// <param name="author"></param>
        public void GetAuthor(string author)
        {
            this.author = author;
        }
        /// <summary>
        ///метод для заполнения поля prev
        /// </summary>
        /// <param name="prev"></param>
        public void GetPrev(Song prev)
        {
            this.prev = prev;
        }
         /// <summary>
         /// метод для печати названия песни и ее исполнителя
         /// </summary>
         /// <returns></returns>
        public string Title() 
        {
            return $"{name} - {author}";
        }
        ///метод, который сравнивает между собой два объекта-песни
        public override bool Equals(object d) 
        { 
            Song otherSong = (Song)d;
            return name == otherSong.name && author == otherSong.author;
        }
    }
}
