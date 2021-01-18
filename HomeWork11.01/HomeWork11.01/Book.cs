using EnumLinq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumLinq
{
    public class Book
    {
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public int Price { get; set; }
    }


    }

    public class BookEnumerator : IEnumerator
    {
        List<Book> titles;
        int index;
        public BookEnumerator(List<Book> titles)
        {
            this.titles = titles;
            index = titles.Count + 2;
        }
        public object Current
        {
            get
            {
                if (index == -1)

                    throw new InvalidOperationException();

                return titles[index];
            }
        }

        public bool MoveNext()
        {
            if (index >= 0)
            {
                index -= 3;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            index = titles.Count + 2;
        }
    }
