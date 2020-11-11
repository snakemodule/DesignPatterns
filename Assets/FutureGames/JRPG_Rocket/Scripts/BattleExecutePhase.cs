using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// Execution phase of battle.
    /// Executes one heros state at a time until they are all done then return to command phase.
    /// </summary>
    public class BattleExecutePhase : FiniteStateMachine<BattleManager>.State
    {
        public BattleExecutePhase(BattleManager fsm) : base(fsm) { }

        public override void Prepare() 
        {

        }

        public override void Execute()
        {
            foreach (var hero in stateMachine.heroesToCommand)
            {
                if (!hero.IsReady())
                {
                    hero.Execute();
                    break;
                }
            }

            if (stateMachine.heroesToCommand.All(hero => hero.IsReady()))
            {
                stateMachine.ChangeState(typeof(BattleCommandPhase));
            }
        }

        public override void End() 
        {

        }
        

    }
}
