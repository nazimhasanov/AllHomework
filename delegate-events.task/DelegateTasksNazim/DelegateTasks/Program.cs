using Delegates_events;
using System;
using System.Collections.Generic;

namespace DelegateTasks
{
    public delegate void Print(int number);
    class Program
    {
        static void Main(string[] args)
        {
            //game task
            GameRecorder gameRecorder = new GameRecorder();
            Game game = new Game("Counter Strike 1.3", GameType.Shooter);

            MessageService msgs = new MessageService();
            MailService ms = new MailService();
            ConsoleService cs = new ConsoleService();

            gameRecorder.A += msgs.OnGameRecorded;
            gameRecorder.A += ms.OnGameRecorded;
            gameRecorder.A += cs.OnGameRecorded;
            gameRecorder.Record(game);

            //Month task

            Program.ListOfMonth();

            string firstValue = string.Empty;
            string lastValue = string.Empty;
            int firstNumber =0;
            int lastNumber =0;
            bool repeatForFirstNumber = true;
            bool repeatForLastNumber = true;
            do
            {
                firstValue = Console.ReadLine();

                if (string.IsNullOrEmpty(firstValue))
                {
                    Console.WriteLine("doldur");
                    firstValue = Console.ReadLine();
                }

                else if (!Int32.TryParse(firstValue, out firstNumber))
                {
                    Console.WriteLine("yalniz reqem daxil etmek olar!");

                    firstValue = Console.ReadLine();
                }
                else if (firstValue.Length  < 1 && firstValue.Length > 12)
                {
                    Console.WriteLine("1 ededen cox ve ya az reqem yazmaq olmaz!");
                    firstValue = Console.ReadLine();
                }
                else
                    repeatForFirstNumber = false;
            
            } while (repeatForFirstNumber);

            if (!repeatForFirstNumber)
            {
                Console.Clear();
                Console.WriteLine("Select what information do you want to know?");
                Console.WriteLine("1. Translated name of month");
                Console.WriteLine("2. Name of season");
            }

            //Last Number
            do
            {
                lastValue = Console.ReadLine();

                if (string.IsNullOrEmpty(lastValue))
                {
                    Console.WriteLine("doldur");
                    lastValue = Console.ReadLine();
                }

                else if (!Int32.TryParse(lastValue, out lastNumber))
                {
                    Console.WriteLine("yalniz reqem daxil etmek olar!");

                    lastValue = Console.ReadLine();
                }
                else if (lastValue.Length < 1 && lastValue.Length > 2)
                {
                    Console.WriteLine("1 ededen cox ve ya az reqem yazmaq olmaz!");

                    lastValue = Console.ReadLine();
                }
                else
                    repeatForLastNumber = false;
            
            } while (repeatForLastNumber);

            if (!repeatForLastNumber)
            {
                //switch
                if (lastNumber == 1)
                {
                    Print print = Program.TranslateMonthName;
                    print.Invoke(firstNumber);
                }
                else if (lastNumber == 2)
                {
                    Print print = Program.PrintSeasonName;
                    print(firstNumber);
                }
            }
        }

        public static void TranslateMonthName(int num)
        {
            switch (num)
            {
                case (int)MonthOfYear.January:
                    {
                        Console.WriteLine("Yanvar", num);
                        break;
                    }
                
                case (int)MonthOfYear.February:
                    {
                        Console.WriteLine("Fevral", num);
                        break;
                    }
                case (int)MonthOfYear.March:
                    {
                        Console.WriteLine("Mart", num);
                        break;
                    }
                case (int)MonthOfYear.April:
                    {
                        Console.WriteLine("Aprel", num);
                        break;
                    }
                case (int)MonthOfYear.May:
                    {
                        Console.WriteLine("May elə maydı", num);
                        break;
                    }
                case (int)MonthOfYear.June:
                    {
                        Console.WriteLine("İyun", num);
                        break;
                    }
                case (int)MonthOfYear.July:
                    {
                        Console.WriteLine("İyul", num);
                        break;
                    }
                case (int)MonthOfYear.August:
                    {
                        Console.WriteLine("Avqust", num);
                        break;
                    }
                case (int)MonthOfYear.September:
                    {
                        Console.WriteLine("Sentyabr", num);
                        break;
                    }
                case (int)MonthOfYear.October:
                    {
                        Console.WriteLine("Oktyabr", num);
                        break;
                    }
                case (int)MonthOfYear.November:
                    {
                        Console.WriteLine("Noyabr", num);
                        break;
                    }
                case (int)MonthOfYear.December:
                    {
                        Console.WriteLine("Dekabr", num);
                        break;
                    }
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }
        public static void PrintSeasonName(int num)
        {
           if(num < 3|| num == 12)
                Console.WriteLine("Winter");
           else if(num > 2 && num < 6)
                Console.WriteLine("Spring");
            else if (num > 5 && num < 9)
                Console.WriteLine("Summer");
            else if (num > 8 && num < 12)
                Console.WriteLine("Autumn");
        }
        public enum MonthOfYear : int
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December

        }
        public static void ListOfMonth()
        {
            Console.WriteLine("Select a month:");
            int i = 1;
            foreach (var name in Enum.GetNames(typeof(MonthOfYear)))
            {
                //Console.WriteLine($"{ Enum.Parse(typeof(MonthOfYear), name).ToString()}.{name}");
                Console.WriteLine($"{i}.{name}");
                i++;
            }
        }

    }
}
