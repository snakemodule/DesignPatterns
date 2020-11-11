
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// Manager statemachine with the two phases of battle.
    /// </summary>
    public class BattleManager : FiniteStateMachine<BattleManager>
    {
        public List<DefaultHero> heroesToCommand;

        public static Action<bool> CommandPhaseEvent = delegate { };

        public BattleManager(List<DefaultHero> heroesToCommand) 
            : base(typeof(BattleCommandPhase))
        {
            this.heroesToCommand = heroesToCommand;
        }

        

    }

}