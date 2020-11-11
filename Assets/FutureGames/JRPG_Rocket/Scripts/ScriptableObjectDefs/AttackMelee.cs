using FutureGames.Lib.Extensions;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// One of two moves that heroes can perform using the strategy pattern
    /// </summary>
    [CreateAssetMenu(fileName = "AttackMelee",
    menuName = "ScriptableObjects/Moves/AttackMelee",
    order = 1)]
    class AttackMelee : MoveData
    {
        public int damage = 5;

        public float movespeed = 10f;

        public override void Perform(DefaultHero hero, EnemyDummy enemy)
        {
            var heroTransform = hero.gameObject.transform;
            var enemyTransform = enemy.gameObject.transform;

            var startingPosition = heroTransform.position;

            var targetPosition =  (startingPosition - enemyTransform.position).normalized+enemyTransform.position;
            
            hero.commands.AddCommand(
                Commands.MoveToCommand(hero.gameObject.transform, targetPosition, movespeed));
            hero.commands.AddCommand(
                Commands.DamageCommand(enemy, damage));
            hero.commands.AddCommand(
                Commands.MoveToCommand(hero.gameObject.transform, startingPosition, movespeed));
        }

    }
}
