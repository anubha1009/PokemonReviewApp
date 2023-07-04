namespace PokemonReviewApp.Models
{
    public class Country
    {
        private int Id { get; set; }
        private string Name { get; set; }

        public ICollection<Owner> Owner { get; set; }
    }
}
