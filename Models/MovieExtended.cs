namespace csharp_boolflix.Models
{
    public class MovieExtended
    {
        public Movie Movie { get; set; }
        public List<Genre>? Genres {  get; set; }
        public List<Genre> SelectedGenres { get; set; }
        public List<Actor>? Actors { get; set; }
        public List<Actor> SelectedActors { get; set; }
        public List<Feature>? Features { get; set; }
        public List<Feature> SelectedFeatures { get; set; }
        public MediaInfo? MediaInfo { get; set; }

        public MovieExtended() {
            Movie = new Movie();
        }
        
    }
}
