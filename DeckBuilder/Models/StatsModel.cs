namespace DeckBuilder.Models
{
    public class StatsModel
    {
        public int Health { get; set; } = 8;
        public int ABV { get; set; } = 0;
        public int Hype { get; set; } = 0;
        public bool Headache { get; set; } = false;
        public bool Sickened { get; set; } = false;
        public bool Anxiety { get; set; } = false;
        public bool Blessed { get; set; } = false;
    }
}
