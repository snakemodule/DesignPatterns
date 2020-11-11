using FutureGames.JRPG_Rocket;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace FutureGames.JRPG_Rocket
{

    /// <summary>
    /// state machine state for the command phase of the demo.
    /// signals the ui throught observer pattern to show the 
    /// action UI and which hero to command
    /// </summary>
    public class BattleCommandPhase : FiniteStateMachine<BattleManager>.State
    {
        public BattleCommandPhase(BattleManager stateMachine) : base(stateMachine) { }

        public override void Prepare() 
        {
            BattleManager.CommandPhaseEvent.Invoke(true);
        }

        public override void Execute()
        {
            //display ready hero in UI, hero.execute will move them from ready when they have a command.

            foreach (var hero in stateMachine.heroesToCommand)
            {
                if (hero.IsReady())
                {
                    DefaultHero.TakingCommandsEvent(hero);
                    hero.Execute();
                    break;
                }
            }

            if (stateMachine.heroesToCommand.All(hero => !hero.IsReady()))
            {
                stateMachine.ChangeState(typeof(BattleExecutePhase));
            }
        }

        public override void End()
        {
            BattleManager.CommandPhaseEvent.Invoke(false);
        }


    }
}