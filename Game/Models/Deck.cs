namespace Game.Models
{
    public class Deck
    {
        public GameCard Draw()
        {
            return new GameCard("TestCard", "This is a test GameCard", 1, 2);
        }
    }
}
