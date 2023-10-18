namespace MZ_DosTablas.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        public List<Promo>? Promos { get; set; }

    }
}
