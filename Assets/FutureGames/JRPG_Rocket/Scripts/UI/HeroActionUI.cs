using System;
using UnityEditor.Experimental.TerrainAPI;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    //UI issues commands to Heroes, uses observer pattern to manage visibility.
    public class HeroActionUI
    {
        DefaultHero hero = null;

        Rect area = new Rect(new Vector2(600, 300), new Vector2(300, 300));

        public HeroActionUI()
        {
            DefaultHero.TakingCommandsEvent += TakingCommands;
        }        

        ~HeroActionUI()
        {
            DefaultHero.TakingCommandsEvent -= TakingCommands;
        }

        private void TakingCommands(DefaultHero hero)
        {            
            this.hero = hero;
        }

        public void OnGUI()
        {
            if (hero != null)
            {
                GUILayout.BeginArea(area);
                GUILayout.Label(hero.name);

                foreach (var move in hero.moves)
                {                    
                    if (GUILayout.Button(move.name))
                    {
                        move.Perform(hero, hero.targetEnemy);
                        hero.ChangeState(typeof(Attacking));
                    }
                }
                GUILayout.EndArea();

            }
        }
    }
}