namespace WebApplication2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Actor> Actors { get; set; }

    }
}
