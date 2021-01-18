using HomeWork12._01;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            foreach (Book l in library)
            {
                Console.WriteLine(l.Title);
                Console.WriteLine($"{l.Price} manat");
                Console.WriteLine(l.PublishedYear);
            }

            List<string> companies = new List<string>
            {
                "Microsoft",
                "Facebook",
                "Twitter",
                "GitHub"
            };

            List<string> socialNetworks = new List<string>
            {
               "Facebook",
               "Twitter",
               "GitHub"
            };

            var result1 = companies.Intersect(socialNetworks);
            var result2 = companies.Except(socialNetworks);
            var result3 = companies.Concat(socialNetworks).Distinct();
            var result4 = companies.Union(socialNetworks);
            foreach (string results in result4)
            {
                Console.WriteLine(results);
            }



        }



    }
}