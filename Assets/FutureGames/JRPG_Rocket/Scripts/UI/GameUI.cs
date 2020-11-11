using System;
using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// The UI uses Events to know which parts of the UI to show.
    /// I decided not to implement data binding to update values 
    /// and stuff in the UI (since the game is basically non-functional and value arent really updated.)
    /// </summary>
    public class GameUI
    {
        HeroActionUI actionUI = null;

        private List<DefaultHero> heroList = null;
        bool commandPhaseActive = true;
        Rect partyStatsArea = new Rect(new Vector2(20, 300), new Vector2(250,300));

        public GameUI(List<DefaultHero> heroList)
        {
            this.heroList = heroList;
            actionUI = new HeroActionUI();
            BattleManager.CommandPhaseEvent += UIActivate;
        }

        ~GameUI()
        {
            BattleManager.CommandPhaseEvent -= UIActivate;
        }
        
        public void OnGUI()
        {
            if (commandPhaseActive)
            {
                actionUI.OnGUI();
            }

            GUILayout.BeginArea(partyStatsArea);
            foreach (var hero in heroList)
            {
                DrawHeroStats(hero);
            }
            GUILayout.EndArea();
        }

        private void DrawHeroStats(DefaultHero hero)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(hero.name);
            GUILayout.Label("HP:"+hero.HP);
            GUILayout.Label(hero.IsReady() ? "Ready" : "Not Ready");                        
            GUILayout.EndHorizontal();
        }

        private void UIActivate(bool active)
        {
            commandPhaseActive = active;
        }        
    }
}