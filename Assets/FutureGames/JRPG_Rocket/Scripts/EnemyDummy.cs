using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    //Dummy tracks damage but does not die
    public class EnemyDummy : Enemy
    {
        public EnemyDummy(GameObject gameObject) : base(gameObject) { }

        public override void Damage(int damage)
        {
            HP -= damage;
        }
        
    }
}