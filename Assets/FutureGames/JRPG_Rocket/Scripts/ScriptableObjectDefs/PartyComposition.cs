using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FutureGames.JRPG_Rocket 
{
    [CreateAssetMenu(fileName = "PartyComposition",
    menuName = "ScriptableObjects/PartyComposition",
    order = 1)]
    public class PartyComposition : ScriptableObject
    {
        public List<HeroData> partyHeroes;
    }
}