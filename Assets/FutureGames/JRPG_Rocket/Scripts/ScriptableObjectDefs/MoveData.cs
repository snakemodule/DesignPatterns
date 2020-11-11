using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace FutureGames.JRPG_Rocket
{    
    /// <summary>
    /// Moves are defined in scriptable objects and 
    /// using a common interface they can be swapped out freely 
    /// making use of the _strategy pattern_, but this time doing it through
    /// the inspector rather than runtime.
    /// </summary>
    public abstract class MoveData : ScriptableObject, IMove
    {
        public abstract void Perform(DefaultHero hero, EnemyDummy enemy);
    }
}