using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// State for hero when they have received command.
    /// </summary>
    public class Attacking : FiniteStateMachine<HeroBase>.State
    {
        public Attacking(HeroBase stateMachine) : base(stateMachine)
        {

        }

        public override void Execute()
        {
            stateMachine.commands.ExecuteCommands();
            if (stateMachine.commands.Empty())
                stateMachine.ChangeState(typeof(Ready));
        }

        public override void Prepare()
        {

        }

        public override void End()
        {

        }
    }
}
