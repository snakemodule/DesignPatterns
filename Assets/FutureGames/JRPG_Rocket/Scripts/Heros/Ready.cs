using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// State for when hero has no command
    /// </summary>
    public class Ready : FiniteStateMachine<HeroBase>.State
    {
        public Ready(HeroBase fsm) : base(fsm) { }

        

        public override void End()
        {

        }

        public override void Execute()
        {
            if (!stateMachine.commands.Empty())
            {
                Debug.Log("Received command");
                stateMachine.ChangeState(typeof(Attacking));

            }
        }

        public override void Prepare()
        {

        }
    }
}