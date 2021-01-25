using Delegates_events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTasks
{
    public class Game
    {
        public string Name { get; set; }

        public GameType Gender { get; set; }

        public Game(string name, GameType gender)
        {
            Name = name;
            Gender = gender;
        }



    }
}
