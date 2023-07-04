namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public ICollection<Review> Reviews { get; set;}
    }
}
