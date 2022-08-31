namespace MagicAPI.Models
{
    public class MagicCardsViewModel
    {
        public List<Card> cards { get; set; }
    }
    
    public class Card
    {
        public string name { get; set; }
        public string manaCost { get; set; }
        public double cmc { get; set; }
        public List<string> colors { get; set; }
        public List<string> colorIdentity { get; set; }
        public string type { get; set; }
        public List<string> types { get; set; }
        public List<string> subtypes { get; set; }
        public string rarity { get; set; }
        public string set { get; set; }
        public string setName { get; set; }
        public string text { get; set; }
        public string artist { get; set; }
        public string number { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }
        public string layout { get; set; }
        public string multiverseid { get; set; }
        public string imageUrl { get; set; }
        public List<string> variations { get; set; }
        public List<ForeignName> foreignNames { get; set; }
        public List<string> printings { get; set; }
        public string originalText { get; set; }
        public string originalType { get; set; }
        public List<Legality> legalities { get; set; }
        public string id { get; set; }
        public string flavor { get; set; }
        public List<Ruling> rulings { get; set; }
        public List<string> supertypes { get; set; }
    }

    public class ForeignName
    {
        public string name { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public object flavor { get; set; }
        public string imageUrl { get; set; }
        public string language { get; set; }
        public object multiverseid { get; set; }
    }

    public class Legality
    {
        public string format { get; set; }
        public string legality { get; set; }
    }

    public class Ruling
    {
        public string date { get; set; }
        public string text { get; set; }
    }


}
