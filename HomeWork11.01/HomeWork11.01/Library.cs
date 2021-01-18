using EnumLinq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWork12._01
{
    public class Library : IEnumerable
    {



        List<Book> titles = new List<Book>()
        {
            new Book
            {
                Title="Jane Austen",
                PublishedYear=DateTime.Now,
                Price=9
            },
            new Book
            {
                Title="Albert Camus",
                PublishedYear=DateTime.Now,
                Price=11
            },
            new Book
            {
                Title="Lev Tolstoy",
                PublishedYear=DateTime.Now,
                Price=16
            },
            new Book
            {
                Title="Gabriel Marquez",
                PublishedYear=DateTime.Now,
                Price=19
            },
            new Book
            {
                Title="Corc Oruell",
                PublishedYear=DateTime.Now,
                Price=18
            },
            new Book
            {
                Title="William Golding",
                PublishedYear=DateTime.Now,
                Price=20
            },
            new Book
            {
                Title="Jose Saramago",
                PublishedYear=DateTime.Now,
                Price=12
            },
             new Book
            {
                Title="Friedrich Nietzsche",
                PublishedYear=DateTime.Now,
                Price=12
            },

        };


        public IEnumerator GetEnumerator()
        {
            
            for (int i = titles.Count - 1; i >= 0; i -= 3)
            {
                yield return titles[i];
            }
        }
    }
}
