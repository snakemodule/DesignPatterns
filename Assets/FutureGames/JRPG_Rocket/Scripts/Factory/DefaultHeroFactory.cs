
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// Factory to encapsulate the creation of hero.
    /// Realistically hero creation would be a simple instantiation of a prefab
    /// But for demo purposes here factory is used to show how it encapsulates the creation of
    /// a complex object (gameobject with components which is injected into hero) 
    /// In a more complete example the factory could return a different child type of HeroBase, 
    /// But here only one type of factory exists DefaultHero
    /// This implementation is based on the UML diagrams from this video https://youtu.be/EcFVTgRHJLM?t=1038
    /// </summary>
    public class DefaultHeroFactory : IHeroFactory
    {
        public HeroBase Create(HeroData data, int placementIndex, int expectedNumberOfHeroes)
        {
            var go = new GameObject(data.Name, typeof(MeshFilter),
                typeof(MeshRenderer));

            go.GetComponent<MeshFilter>().mesh = data.Mesh ;
            go.GetComponent<MeshRenderer>().material = data.Material;

            DefaultHero newHeroInstance = new DefaultHero(go, data.Moves);
            newHeroInstance.name = data.Name;

            float lineupWidth = 6f;
            float distance = lineupWidth / expectedNumberOfHeroes;
            float Zpos = (placementIndex * distance) - (lineupWidth*0.5f);
            go.transform.position = new Vector3(0,0,Zpos);

            return newHeroInstance;
        }

    }
}
