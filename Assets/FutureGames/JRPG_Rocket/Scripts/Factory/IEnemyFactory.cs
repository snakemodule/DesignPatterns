using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    interface IEnemyFactory
    {
        Enemy Create(EnemyData data, Vector3 position);
    }
}
