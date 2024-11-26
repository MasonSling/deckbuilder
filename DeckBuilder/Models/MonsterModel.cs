namespace DeckBuilder.Models
{
    public class MonsterModel
    {
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;

        public int Count { get; set; } = 0; // New property for the badge counter
    }
}
