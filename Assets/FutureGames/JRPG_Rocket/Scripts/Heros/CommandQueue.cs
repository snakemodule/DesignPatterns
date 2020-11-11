using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// adapted command invoker.
    /// queue of commands where each command function is executed multiple times until 
    /// it returns true in order to perform some behaviour over update cycles.
    /// </summary>
    public class CommandQueue
    {
        private Queue<Func<bool>> commands = new Queue<Func<bool>>();

        public void AddCommand(Func<bool> closure)
        {
            commands.Enqueue(closure);
        }

        public void ExecuteCommands()
        {
            while (!Empty() && commands.Peek().Invoke())
            {
                commands.Dequeue();
            }
        }

        public bool Empty()
        {
            return commands.Count == 0;
        }

        public void Clear()
        {
            commands.Clear();
        }

    }
}