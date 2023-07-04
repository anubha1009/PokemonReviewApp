namespace PokemonReviewApp.Models
{
    public class Review
    {
        private int Id { get; set; }
        private string Title { get; set; }
        private string Text { get; set; }
        public Reviewer Reviewer { get; set; }

        public Pokemon Pokemon { get; set; }
    }
}
