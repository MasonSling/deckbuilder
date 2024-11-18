namespace DeckBuilder.Models
{
    public class CardModel
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }

        public int PlayerId { get; set; }
    }
}
