using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// Concrete factory to encapsulate the creation of enemy dummy
    /// </summary>
    public class DummyFactory : IEnemyFactory
    {
        public Enemy Create(EnemyData data, Vector3 position)
        {
            var go = new GameObject(data.Name, typeof(MeshFilter),
                typeof(MeshRenderer));

            go.GetComponent<MeshFilter>().mesh = data.Mesh;
            go.GetComponent<MeshRenderer>().material = data.Material;

            EnemyDummy e = new EnemyDummy(go);

            go.transform.position = position;


            return e;
        }
    }
}