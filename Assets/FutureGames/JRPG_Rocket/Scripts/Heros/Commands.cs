using System;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// Inspired by https://journal.stuffwithstuff.com/2009/07/02/closures-and-the-command-pattern/
    /// Commands are Func<bool> closures rather than classes with members to hold arguments.    
    /// </summary>
    public static class Commands
    {
        
        public static Func<bool> MoveToCommand(Transform mover, Vector3 target, float speed)
        {
            return () => {
                mover.position = Vector3.MoveTowards(mover.position, target, speed * Time.deltaTime);
                return mover.position == target;
            };
        }


        public static Func<bool> DamageCommand(EnemyDummy enemy, int damage)
        {
            return () => {
                enemy.Damage(damage);
                return true;
            };
        }
    }
}
