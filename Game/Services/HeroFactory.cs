using Game.Models.Hero;

namespace Game.Services
{
    public class HeroFactory : IFactory<IHero>
    {
        public IHero Create(int id)
        {
            return id switch
            {
                1 => new Berserker(),
                2 => new Ranger(),
                3 => new Tank(),
                _ => new Berserker()
            };
        }
    }
}
