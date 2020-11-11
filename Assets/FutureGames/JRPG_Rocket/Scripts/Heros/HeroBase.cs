using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// The hero is a statemachine, the states that it starts in is 
    /// defined by the base constructor argument
    /// </summary>
    public abstract class HeroBase : FiniteStateMachine<HeroBase>
    {
        public GameObject gameObject = null;
        public List<MoveData> moves;
        public int HP = 10;
        public string name = "Default Name";
        public CommandQueue commands = new CommandQueue();

        public HeroBase(GameObject gameObject, List<MoveData> moves)
            : base(typeof(Ready))
        {
            this.gameObject = gameObject;
            this.moves = moves;
        }

        public bool IsReady()
        {
            return IsInState(typeof(Ready));
        }

    }
}
