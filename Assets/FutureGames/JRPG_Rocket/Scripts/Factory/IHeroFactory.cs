namespace FutureGames.JRPG_Rocket
{
    public interface IHeroFactory
    {
        HeroBase Create(HeroData data, int placementIndex, int expectedNumberOfHeroes);
    }
}