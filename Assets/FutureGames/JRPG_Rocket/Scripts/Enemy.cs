using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public abstract class Enemy
    {
        protected int HP = 10;

        public GameObject gameObject;

        public Enemy(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }

        public abstract void Damage(int damage);
    }
}