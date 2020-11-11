using FutureGames.Lib.Extensions;
using System;
using System.Diagnostics;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// One of two moves that heroes can perform using the strategy pattern
    /// </summary>
    [CreateAssetMenu(fileName = "AttackRanged",
    menuName = "ScriptableObjects/Moves/AttackRanged",
    order = 1)]
    class AttackRanged : MoveData
    {
        public int damage = 3;
               
        public float movespeed = 2f;

        public override void Perform(DefaultHero hero, EnemyDummy enemy)
        {
            var startingPosition = hero.gameObject.transform.position;
            var targetPosition = startingPosition.With(x:startingPosition.x+1);
            hero.commands.AddCommand(
                Commands.MoveToCommand(hero.gameObject.transform, targetPosition, movespeed));
            hero.commands.AddCommand(
                Commands.DamageCommand(enemy, damage));
            hero.commands.AddCommand(
                Commands.MoveToCommand(hero.gameObject.transform, startingPosition, movespeed));
        }
    }
}
