using Delegates_events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTasks
{
    public class GameRecorder
    {
        public event EventHandler<GameEventArgs> A;


        public void OnGameRecorded(Game game)
        {
            A?.Invoke(this, new GameEventArgs() { Game = game });
        }

        public void Record(Game game)
        {
            Console.WriteLine("Recording..");

            OnGameRecorded(game);
        }
    }
}
