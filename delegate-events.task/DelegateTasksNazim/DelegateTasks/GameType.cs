using DelegateTasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_events
{


    public enum GameType
    {
        Shooter,
        Action,
        Quest
    }

   

    public class GameEventArgs : EventArgs
    {
        public Game Game { get; set; }
    }

   

    public class ConsoleService
    {
        public void OnGameRecorded(object s, GameEventArgs args)
        {
            Console.WriteLine($"Printing from ConsoleService:  { args.Game.Name} , {args.Game.Gender}");
        }
    }

    public class MailService
    {
        public void OnGameRecorded(object s, GameEventArgs args)
        {
            Console.WriteLine($"Printing from MailService:  { args.Game.Name} , {args.Game.Gender}");
        }
    }

    public class MessageService
    {
        public void OnGameRecorded(object s, GameEventArgs args)
        {
            Console.WriteLine($"Printing from MessageService:  { args.Game.Name} , {args.Game.Gender}");
        }
    }
}
