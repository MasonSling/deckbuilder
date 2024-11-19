namespace DeckBuilder.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public List<CardModel> Deck { get; set; } = new();
        public List<CardModel> DiscardPile { get; set; } = new();
        public List<CardModel> Hand { get; set; } = new();
        public List<CardModel> PlayedCards { get; set; } = new();

        public StatsModel Stats { get; set; } = new();
        public PlayerModel(string name)
        {
            Name = name;
        }
    }
}
