namespace Game.Models.Card
{
    public interface ICard
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int? Attack { get; set; }

        public int? Defense { get; set; }
    }
}
