using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// The entire demo runs from this Monobehaviour.
    /// The heroes are issued commands in one phase
    /// Then they take turns executing their orders.
    /// The enemy is a dummy and does not fight back or die.
    /// </summary>
    public class MainMono : MonoBehaviour
    {
        [SerializeField] private PartyComposition party = null;
        [SerializeField] private EnemyData bossData = null;

        private BattleManager manager = null;

        private GameUI ui= null;

        private List<DefaultHero> heroes = null;
        private EnemyDummy boss = null;

        private void Awake()
        {
            
            boss = (EnemyDummy)new DummyFactory().Create(bossData, new Vector3(12, 0, 0));
            heroes = new List<DefaultHero>(party.partyHeroes.Count);
            var heroFactory = new DefaultHeroFactory();
            for (int i = 0; i < party.partyHeroes.Count; i++)                
            {
                DefaultHero newHero = (DefaultHero)heroFactory.Create(party.partyHeroes[i], i, party.partyHeroes.Count);
                newHero.targetEnemy = boss;
                heroes.Add(newHero);
            }

            manager = new BattleManager(heroes);
            ui = new GameUI(heroes);
        }        

        // Update is called once per frame
        void Update()
        {
            manager.Execute();
        }

        void OnGUI()
        {
            ui.OnGUI();
        }
    }
}