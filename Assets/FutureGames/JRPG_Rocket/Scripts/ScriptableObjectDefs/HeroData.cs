using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    [CreateAssetMenu(fileName = "HeroData",
    menuName = "ScriptableObjects/HeroData",
    order = 1)]
    public class HeroData : ScriptableObject
    {
        public Material Material;
        public Mesh Mesh;
        public string Name = "Default Name";
        public List<MoveData> Moves;

    }

}