namespace Game.Models
{
    public class Deck
    {
        public Card Draw()
        {
            return new Card("TestCard", "This is a test Card", 1, 2);
        }
    }
}
