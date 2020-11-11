using System;
using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    
    public class DefaultHero : HeroBase
    {

   

        public EnemyDummy targetEnemy = null;


        public static Action<DefaultHero> TakingCommandsEvent = delegate { };




        public DefaultHero(GameObject gameObject, List<MoveData> moves) 
            : base(gameObject,moves)
        {}

        
        
    }
}