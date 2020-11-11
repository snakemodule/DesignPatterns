using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// This interface 
    /// </summary>
    public interface IMove
    {
        void Perform(DefaultHero hero, EnemyDummy enemy);
    }
}
