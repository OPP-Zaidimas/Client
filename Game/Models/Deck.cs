using Game.Services.AbstractFactory;

namespace Game.Models
{
    public class Deck
    {
        private readonly ICardFactory _factory;

        public Deck(ICardFactory factory)
        {
            _factory = factory;
        }

        public GameCard Draw()
        {
            return new GameCard("TestCard", "This is a test GameCard", 1, 2);
        }
    }
}
