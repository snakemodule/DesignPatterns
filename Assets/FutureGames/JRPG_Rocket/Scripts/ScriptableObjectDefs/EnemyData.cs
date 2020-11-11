using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    [CreateAssetMenu(fileName = "EnemyData",
    menuName = "ScriptableObjects/EnemyData",
    order = 1)]
    public class EnemyData : ScriptableObject
    {
        public Material Material;
        public Mesh Mesh;
        public string Name = "Enemy Name";
    }
}
